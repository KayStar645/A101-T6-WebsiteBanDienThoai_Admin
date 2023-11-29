using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Domain.ModelViews;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;
using System.Reflection;
using System.Transactions;

namespace Services.Services
{
    public class PromotionService : IPromotionService, IService
    {
        private readonly IPromotionRepository _promotionRepo;
        private readonly IPromotionProductRepository _promotionProductRepo;
        private readonly IMapper _mapper;

        public PromotionService(IPromotionRepository promotionRepo, IPromotionProductRepository promotionProductRepo, IMapper mapper) 
        {
            _promotionRepo = promotionRepo;
            _promotionProductRepo = promotionProductRepo;
            _mapper = mapper;
        }

        [RequirePermission("Promotion.View")]
        public async Task<(List<PromotionDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _promotionRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<PromotionDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Promotion.View")]
        public async Task<PromotionDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var promotion = await _promotionRepo.GetDetailAsync(pId);

            var promotionDto = _mapper.Map<PromotionDto>(promotion);

            var products = await _promotionProductRepo.GetProductsByPromotionId(pId);

            promotionDto.Products = _mapper.Map<List<ProductVM>>(products);

            return promotionDto;
        }

        [RequirePermission("Promotion.Create")]
        public async Task<int> Create(PromotionDto pCreate)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            pCreate.Status = Promotion.STATUS_DRAFT;

            PromotionValidator validator = new PromotionValidator(_promotionRepo, pCreate.Start, pCreate.Type);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var promotion = _mapper.Map<Promotion>(pCreate);

            var result = await _promotionRepo.AddAsync(promotion);

            return result;
        }

        [RequirePermission("Promotion.Update")]
        public async Task<bool> Update(PromotionDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            PromotionValidator validator = new PromotionValidator(_promotionRepo, pUpdate.Start, pUpdate.Type, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var promotion = _mapper.Map<Promotion>(pUpdate);

            var result = await _promotionRepo.UpdateAsync(promotion);

            return result > 0;
        }

        [RequirePermission("Promotion.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _promotionRepo.DeleteAsync(pId);

            return result;
        }

        [RequirePermission("Promotion.Approve")]
        public async Task<bool> Approve(int pId, string type)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _promotionRepo.ApproveAsync(pId, type);

            return result;
        }

        [RequirePermission("Promotion.Apply")]
        public async Task<bool> ApplyForProduct(int pId, List<int> pProductsId)
        {
            if (CustomMiddleware.CheckPermission(MethodBase.GetCurrentMethod()) == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            using (var transaction = new TransactionScope())
            {
                try
                {
                    var promotionsWithId = await _promotionProductRepo.GetAllAsync(pFilter: $"PromotionId:{pId}");

                    var oldProductsId = promotionsWithId.list.Select(x => x.ProductId).ToList();

                    List<int> deleteProductIds = oldProductsId.Except(pProductsId).ToList();
                    List<int> addProductIds = pProductsId.Except(oldProductsId).ToList();

                    foreach (int productId in deleteProductIds)
                    {
                        await _promotionProductRepo.DeleteAsync(pId, productId);
                    }

                    foreach (int productId in addProductIds)
                    {
                        await _promotionProductRepo.AddAsync(new PromotionProduct
                        {
                            PromotionId = pId,
                            ProductId = productId,
                        });
                    }
                    transaction.Complete();
                    return true;
                }
                catch
                {
                    transaction.Dispose();
                    return false;
                }
            }

            
        }
    }
}
