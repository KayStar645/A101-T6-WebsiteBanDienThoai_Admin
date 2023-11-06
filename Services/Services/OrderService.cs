using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using System.Transactions;

namespace Services.Services
{
    public class OrderService : IOrderService
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

        public async Task<OrderDto> GetDetail(int pId)
        {
            var result = await _orderRepo.GetDetailPropertiesAsync(pId);

            return result;
        }

        public async Task<(List<OrderDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1,
            int? pPageSize = 30, string? pKeyword = "", int? pEmployeeId = null, int? pCustomerId = null)
        {
            var result = await _orderRepo.GetAllPropertiesAsync(pKeyword, pSort, pPageNumber, pPageSize, pEmployeeId, pCustomerId);

            return result;
        }


        // Create Order: Khách đặt hàng, type = O
        // Chỉ cần cần chọn sp, số lượng, giá sẽ tự tính
        public async Task<bool> Create(OrderDto pOrder)
        {
            pOrder.Type = Order.TYPE_ORDER;
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

                            sumPrice[0] += (long)resultPromotionProduct.oldPrice;
                            sumPrice[1] += (long)resultPromotionProduct.discount;
                            sumPrice[2] += sumPrice[0] - sumPrice[1];

                            detailOrder.Price = sumPrice[0];
                            detailOrder.DiscountPrice = sumPrice[1];
                            detailOrder.SumPrice = sumPrice[0] - sumPrice[1];

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
                    if (update == false)
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
        public async Task<bool> ChangeTypeOrder(int pOrderId, string pType)
        {
            var result = await _orderRepo.ChangeTypeOrderAsync(pOrderId, pType);

            return result;
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
                    discount = promotion.Discount > price ? price : promotion.Discount;  
                }
                else
                {
                    discount = promotion.Percent * price;
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
