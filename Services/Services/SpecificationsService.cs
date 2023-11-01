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

        public async Task<(List<SpecificationsDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _specificationsRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<SpecificationsDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<bool> Create(SpecificationsDto pCreate)
        {
            var specifications = _mapper.Map<Specifications>(pCreate);

            var result = await _specificationsRepo.AddAsync(specifications);

            return result > 0;
        }

        public async Task<bool> Update(SpecificationsDto pUpdate)
        {
            var specifications = _mapper.Map<Specifications>(pUpdate);

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
