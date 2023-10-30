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

        public async Task<(List<DetailSpecificationsDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _detailSpecificationsRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<DetailSpecificationsDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<DetailSpecificationsDto> GetDetail(int pId)
        {
            var detailSpecifications = await _detailSpecificationsRepo.GetDetailAsync(pId);

            var detailSpecificationsDto = _mapper.Map<DetailSpecificationsDto>(detailSpecifications);

            return detailSpecificationsDto;
        }

        public async Task<bool> Create(DetailSpecificationsDto pCreate)
        {
            var detailSpecifications = _mapper.Map<DetailSpecifications>(pCreate);

            var result = await _detailSpecificationsRepo.AddAsync(detailSpecifications);

            return result > 0;
        }

        public async Task<bool> Update(DetailSpecificationsDto pUpdate)
        {
            var detailSpecifications = _mapper.Map<DetailSpecifications>(pUpdate);

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
