using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;

namespace Services.Services
{
    public class DistributorService : IDistributorService
    {

        private readonly IDistributorRepository _distributorRepo;
        private readonly IMapper _mapper;

        public DistributorService(IDistributorRepository distributorRepository, IMapper mapper)
        {
            _distributorRepo = distributorRepository;
            _mapper = mapper;
        }

        public async Task<(List<DistributorDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _distributorRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<DistributorDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<DistributorDto> GetDetail(int pId)
        {
            var distributor = await _distributorRepo.GetDetailAsync(pId);

            var distributorDto = _mapper.Map<DistributorDto>(distributor);

            return distributorDto;
        }

        public async Task<bool> Create(DistributorDto pCreate)
        {
            Distributor distributor = _mapper.Map<Distributor>(pCreate);

            var result = await _distributorRepo.AddAsync(distributor);
            
            return result > 0;
        }

        public async Task<bool> Update(DistributorDto pCreate)
        {
            Distributor distributor = _mapper.Map<Distributor>(pCreate);

            var result = await _distributorRepo.UpdateAsync(distributor);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _distributorRepo.DeleteAsync(pId);

            return result;
        }
    }
}
