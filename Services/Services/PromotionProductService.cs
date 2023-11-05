using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class PromotionProductService : IPromotionProductService
    {
        private readonly IPromotionProductRepository _promotionProductRepo;
        private readonly IMapper _mapper;

        public PromotionProductService(IPromotionProductRepository promotionProduct, IMapper mapper)
        {
            _promotionProductRepo = promotionProduct;
            _mapper = mapper;
        }

        public async Task<(List<PromotionProductDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _promotionProductRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<PromotionProductDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<bool> Create(PromotionProductDto pCreate)
        {
            PromotionProduct promotionProduct = _mapper.Map<PromotionProduct>(pCreate);

            var result = await _promotionProductRepo.AddAsync(promotionProduct);

            return result > 0;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _promotionProductRepo.DeleteAsync(pId);

            return result;
        }
    }
}
