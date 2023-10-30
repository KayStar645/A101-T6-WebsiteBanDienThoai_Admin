using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class DetailSpecificationsService : IDetailSpecificationsService
    {
        private readonly IDetailSpecificationsRepository _detailSpecificationsRepo;
        private readonly IMapper _mapper;

        public DetailSpecificationsService(IDetailSpecificationsRepository detailSpecificationsRepository, IMapper mapper)
        {
            _detailSpecificationsRepo = detailSpecificationsRepository;
            _mapper = mapper;
        }

        public async Task<(List<DetailSpecificationsDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _detailSpecificationsRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<DetailSpecificationsDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<DetailSpecificationsDto> GetDetail(int pId)
        {
            var detailSpecifications = await _detailSpecificationsRepo.GetDetailAsync(pId);

            var detailSpecificationsDto = _mapper.Map<DetailSpecificationsDto>(detailSpecifications);

            return detailSpecificationsDto;
        }

        public async Task<bool> Create(DetailSpecificationsDto pCreateDetailSpecifications)
        {
            var detailSpecifications = _mapper.Map<DetailSpecifications>(pCreateDetailSpecifications);

            var result = await _detailSpecificationsRepo.AddAsync(detailSpecifications);

            return result;
        }

        public async Task<bool> Update(DetailSpecificationsDto pUpdateDetailSpecifications)
        {
            var detailSpecifications = _mapper.Map<DetailSpecifications>(pUpdateDetailSpecifications);

            var result = await _detailSpecificationsRepo.UpdateAsync(detailSpecifications);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _detailSpecificationsRepo.DeleteAsync(pId);

            return result;
        }
    }
}
