using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class SpecificationsService : ISpecificationsService
    {
        private readonly ISpecificationsRepository _specificationsRepo;
        private readonly IMapper _mapper;

        public SpecificationsService(ISpecificationsRepository specificationsRepository, IMapper mapper)
        {
            _specificationsRepo = specificationsRepository;
            _mapper = mapper;
        }

        public async Task<(List<SpecificationsDto> list, int totalCount)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _specificationsRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<SpecificationsDto>>(result.list);

            return (list, result.totalCount);
        }

        public async Task<SpecificationsDto> GetDetail(int pId)
        {
            var specifications = await _specificationsRepo.GetDetailAsync(pId);

            var specificationsDto = _mapper.Map<SpecificationsDto>(specifications);

            return specificationsDto;
        }

        public async Task<bool> Create(SpecificationsDto pCreateSpecifications)
        {
            var specifications = _mapper.Map<Specifications>(pCreateSpecifications);

            var result = await _specificationsRepo.AddAsync(specifications);

            return result;
        }

        public async Task<bool> Update(SpecificationsDto pUpdateSpecifications)
        {
            var specifications = _mapper.Map<Specifications>(pUpdateSpecifications);

            var result = await _specificationsRepo.UpdateAsync(specifications);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _specificationsRepo.DeleteAsync(pId);

            return result;
        }
    }
}
