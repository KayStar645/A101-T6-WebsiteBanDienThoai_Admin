using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class PromotionService : IPromotionService
    {
        private readonly IPromotionRepository _promotionRepo;
        private readonly IMapper _mapper;

        public PromotionService(IPromotionRepository promotionRepo, IMapper mapper) 
        {
            _promotionRepo = promotionRepo;
            _mapper = mapper;
        }

        public async Task<(List<PromotionDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _promotionRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<PromotionDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<PromotionDto> GetDetail(int pId)
        {
            var promotion = await _promotionRepo.GetDetailAsync(pId);

            var promotionDto = _mapper.Map<PromotionDto>(promotion);

            return promotionDto;
        }

        public async Task<bool> Create(PromotionDto pCreate)
        {
            pCreate.Status = Promotion.STATUS_DRAFT;
            var promotion = _mapper.Map<Promotion>(pCreate);

            var result = await _promotionRepo.AddAsync(promotion);

            return result > 0;
        }

        public async Task<bool> Update(PromotionDto pUpdate)
        { 
            var promotion = _mapper.Map<Promotion>(pUpdate);

            var result = await _promotionRepo.UpdateAsync(promotion);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _promotionRepo.DeleteAsync(pId);

            return result;
        }

        public async Task<bool> Approve(int pId, string type)
        {
            var result = await _promotionRepo.ApproveAsync(pId, type);

            return result;
        }
    }
}
