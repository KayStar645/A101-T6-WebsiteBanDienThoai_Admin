using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Common;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;
using System.Transactions;

namespace Services.Services
{
    public class OrderService : IOrderService, IService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IMapper _mapper;
        private readonly IDetailOrderRepository _detailOrderRepo;
        private readonly IProductRepository _productRepo;
        private readonly IPromotionRepository _promotionRepo;

        public OrderService(IOrderRepository orderRepository, IMapper mapper,
            IDetailOrderRepository detailOrderRepository, IProductRepository productRepo, 
            IPromotionRepository promotionRepository)
        {
            _orderRepo = orderRepository;
            _mapper = mapper;
            _detailOrderRepo = detailOrderRepository;
            _productRepo = productRepo;
            _promotionRepo = promotionRepository;
        }

        [RequirePermission("Order.View")]
        public async Task<OrderDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Order.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _orderRepo.GetDetailPropertiesAsync(pId);

            return result;
        }

        [RequirePermission("Order.View")]
        public async Task<(List<OrderDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pCustomerId = null)
        {
            if (CustomMiddleware.CheckPermission("Order.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _orderRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pEmployeeId, pCustomerId);

            return result;
        }


        // Create Order: Khách đặt hàng, type = O
        // Chỉ cần cần chọn sp, số lượng, giá sẽ tự tính
        [RequirePermission("Order.Create")]
        public async Task<bool> Create(OrderDto pOrder)
        {
            if (CustomMiddleware.CheckPermission("Order.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            OrderValidator validator = new OrderValidator(_orderRepo, _detailOrderRepo);
            var validationResult = await validator.ValidateAsync(pOrder);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            pOrder.Type = Order.TYPE_ORDER;
            pOrder.OrderDate = DateTime.Now;

            using (var transaction = new TransactionScope())
            {
                try
                {
                    bool flag = true;
                    // Tạo đơn hàng
                    var order = _mapper.Map<Order>(pOrder);
                    var resultImport = await _orderRepo.AddAsync(order);

                    long[] sumPrice = new long[] { 0, 0, 0 }; // Hiện tại, giảm, sau giảm

                    if (resultImport > 0)
                    {
                        // Duyệt qua chi tiết đơn hàng
                        foreach (var detailOrder in pOrder.Details)
                        {
                            // Áp dụng khuyến mãi
                            var resultPromotionProduct = await PriceAfterApprovePromotionForProduct((int)detailOrder.ProductId);

                            sumPrice[0] += (long)(resultPromotionProduct.oldPrice * detailOrder.Quantity);
                            sumPrice[1] += (long)resultPromotionProduct.discount;
                            sumPrice[2] += (long)((resultPromotionProduct.oldPrice - resultPromotionProduct.discount) * detailOrder.Quantity);

                            detailOrder.Price = (long)resultPromotionProduct.oldPrice;
                            detailOrder.DiscountPrice = (long)resultPromotionProduct.discount;
                            detailOrder.SumPrice = (detailOrder.Price - detailOrder.DiscountPrice) * detailOrder.Quantity;

                            detailOrder.OrderId = resultImport;
                            var detail = _mapper.Map<DetailOrder>(detailOrder);

                            var resultDetail = await _detailOrderRepo.AddAsync(detail);
                            if (resultDetail < 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    order.Price = sumPrice[0];
                    order.DiscountPrice = sumPrice[1];
                    order.SumPrice = sumPrice[2];

                    var update = await _orderRepo.UpdateAsync(order);
                    if (update == 0)
                    {
                        flag = false;
                    }

                    if (flag) { transaction.Complete(); }
                    else { transaction.Dispose(); }

                    return flag;
                }
                catch (Exception)
                {
                    transaction.Dispose();
                    return false;
                }
            }
        }

        [RequirePermission("Order.Update")]
        public async Task<bool> Update(OrderDto pOrder)
        {
            if (CustomMiddleware.CheckPermission("Order.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            OrderValidator validator = new OrderValidator(_orderRepo, _detailOrderRepo, false, pOrder.Id);
            var validationResult = await validator.ValidateAsync(pOrder);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            if (pOrder.Type != Order.TYPE_ORDER)
            {
                throw new Exception("Chỉ có thể cập nhật đơn hàng ở trạng thái nháp!");
            }

            using (var transaction = new TransactionScope())
            {
                try
                {
                    bool flag = true;
                    long[] sumPrice = new long[] { 0, 0, 0 }; // Hiện tại, giảm, sau giảm

                    do
                    {
                        var oldOrder = await _orderRepo.GetDetailPropertiesAsync(pOrder.Id);

                        var orderDetailIdComparer = new OrderDetailIdComparer();

                        var deleteDetailOrder = oldOrder.Details.Except(pOrder.Details, orderDetailIdComparer).ToList();
                        var updateDetailOrder = pOrder.Details.Intersect(oldOrder.Details, orderDetailIdComparer).ToList();
                        var addDetailOrder = pOrder.Details.Except(oldOrder.Details, orderDetailIdComparer).ToList();

                        // Xóa chi tiết
                        foreach (var detailOrder in deleteDetailOrder)
                        {
                            var resultDetail = await _detailOrderRepo.DeleteAsync(detailOrder.Id);
                            if (resultDetail == false)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if(flag == false)
                        {
                            break;
                        }

                        // Sửa chi tiết
                        foreach (var detailOrder in updateDetailOrder)
                        {
                            // Áp dụng khuyến mãi
                            var resultPromotionProduct = await PriceAfterApprovePromotionForProduct((int)detailOrder.ProductId);

                            sumPrice[0] += (long)(resultPromotionProduct.oldPrice * detailOrder.Quantity);
                            sumPrice[1] += (long)resultPromotionProduct.discount;
                            sumPrice[2] += (long)((resultPromotionProduct.oldPrice - resultPromotionProduct.discount) * detailOrder.Quantity);

                            detailOrder.Price = (long)resultPromotionProduct.oldPrice;
                            detailOrder.DiscountPrice = (long)resultPromotionProduct.discount;
                            detailOrder.SumPrice = (detailOrder.Price - detailOrder.DiscountPrice) * detailOrder.Quantity;

                            var detail = _mapper.Map<DetailOrder>(detailOrder);
                            var resultDetail = await _detailOrderRepo.UpdateAsync(detail);

                            if (resultDetail == 0)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag == false)
                        {
                            break;
                        }

                        // Thêm chi tiết
                        foreach (var detailOrder in addDetailOrder)
                        {
                            // Áp dụng khuyến mãi
                            var resultPromotionProduct = await PriceAfterApprovePromotionForProduct((int)detailOrder.ProductId);

                            sumPrice[0] += (long)(resultPromotionProduct.oldPrice * detailOrder.Quantity);
                            sumPrice[1] += (long)resultPromotionProduct.discount;
                            sumPrice[2] += (long)((resultPromotionProduct.oldPrice - resultPromotionProduct.discount) * detailOrder.Quantity);

                            detailOrder.Price = (long)resultPromotionProduct.oldPrice;
                            detailOrder.DiscountPrice = (long)resultPromotionProduct.discount;
                            detailOrder.SumPrice = (detailOrder.Price - detailOrder.DiscountPrice) * detailOrder.Quantity;

                            detailOrder.OrderId = pOrder.Id;

                            var detail = _mapper.Map<DetailOrder>(detailOrder);
                            var resultDetail = await _detailOrderRepo.AddAsync(detail);

                            if (resultDetail == 0)
                            {
                                flag = false;
                                break;
                            }
                        }

                    } while (false);

                    var order = _mapper.Map<Order>(pOrder);

                    order.Price = sumPrice[0];
                    order.DiscountPrice = sumPrice[1];
                    order.SumPrice = sumPrice[2];

                    var update = await _orderRepo.UpdateAsync(order);
                    if (update == 0)
                    {
                        flag = false;
                    }

                    if (flag) { transaction.Complete(); }
                    else { transaction.Dispose(); }

                    return flag;
                }
                catch (Exception)
                {
                    transaction.Dispose();
                    return false;
                }
            }
        }


        // Approve Order: Nhân viên thay đổi trạng thái đơn hàng, type = O -> A -> T -> E
        // Hủy đơn hàng: Nhân viên hoặc khách hủy, type = O -> C
        [RequirePermission("Order.Approve")]
        public async Task<bool> ChangeTypeOrder(int pOrderId, string pType)
        {
            if (CustomMiddleware.CheckPermission("Order.Approve") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }

            using (var transaction = new TransactionScope())
            {
                try
                {
                    // Cập nhật lại nhân viên duyệt đơn hàng
                    var oldOrder = await _orderRepo.GetDetailPropertiesAsync(pOrderId);
                    oldOrder.EmployeeId = ServiceCommon.AuthRespone.Id;

                    var order = _mapper.Map<Order>(oldOrder);
                    var update = await _orderRepo.UpdateAsync(order);

                    if (pType == Order.TYPE_TRANSPORT)
                    {
                        // Giảm số lượng của tất cả sản phẩm trong đơn hàng này
                        await _orderRepo.UpdateQuantityProductWhenTransportOrder(pOrderId, true);
                    }

                    if (pType == Order.TYPE_CANNEL)
                    {
                        // Nếu trạng thái trước đó của đơn hàng là T (Đang vận chuyển) - Đã kiểm tra trong Repo
                        // Tăng số lượng của tất cả sản phẩm này lên lại
                        await _orderRepo.UpdateQuantityProductWhenTransportOrder(pOrderId, false);
                    }


                    var result = await _orderRepo.ChangeTypeOrderAsync(pOrderId, pType);
                    transaction.Complete();
                    return result;
                }   
                catch
                {
                    transaction.Dispose();
                    return false;
                }
            }    
        }

        // Áp dụng chương trình khuyến mãi cho 1 sản phẩm
        private async Task<(PromotionDto promotion, long? oldPrice, long? discount)> PriceAfterApprovePromotionForProduct(int pProductId)
        {
            var product = await _productRepo.GetDetailAsync(pProductId);
            long? price = product.Price ?? 0;

            var promotions = await _promotionRepo.GetByProductId(pProductId);

            long? priceDiscountMax = 0;
            Promotion p = null;
            foreach(var promotion in promotions)
            {
                long? discount = 0;
                if (promotion.Type == Promotion.TYPE_DISCOUNT)
                {
                    long? discountMax = promotion.PercentMax * price;
                    discount = promotion.Discount > discountMax ? discountMax : promotion.Discount;  
                }
                else
                {
                    long? discountCurrent = promotion.Percent * price;
                    discount = discountCurrent > promotion.DiscountMax ? promotion.DiscountMax : discountCurrent;
                }

                if (discount > priceDiscountMax)
                {
                    priceDiscountMax = discount;
                    p = promotion;
                }
            }
            var promotionDto = _mapper.Map<PromotionDto>(p);
            return (promotionDto, price, priceDiscountMax);
        }

    }
}
