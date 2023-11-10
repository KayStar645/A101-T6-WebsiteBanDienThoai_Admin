using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Validators;

namespace Services.Services
{
    public class CapacityService : ICapacityService
    {
        private readonly ICapacityRepository _capacityRepo;
        private readonly IMapper _mapper;

        public CapacityService(ICapacityRepository capacityRepository, IMapper mapper) 
        {
            _capacityRepo = capacityRepository;
            _mapper = mapper;
        }

        public async Task<(List<CapacityDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            var result = await _capacityRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<CapacityDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        public async Task<CapacityDto> GetDetail(int pId)
        {
            var capacity = await _capacityRepo.GetDetailAsync(pId);

            var capacityDto = _mapper.Map<CapacityDto>(capacity);

            return capacityDto;
        }

        public async Task<bool> Create(CapacityDto pCreate)
        {
            CapacityValidator validator = new CapacityValidator(_capacityRepo);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var capacity = _mapper.Map<Capacity>(pCreate);

            var result = await _capacityRepo.AddAsync(capacity);

            return result > 0;
        }

        public async Task<bool> Update(CapacityDto pUpdate)
        {
            CapacityValidator validator = new CapacityValidator(_capacityRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var capacity = _mapper.Map<Capacity>(pUpdate);

            var result = await _capacityRepo.UpdateAsync(capacity);

            return result;
        }

        public async Task<bool> Delete(int pId)
        {
            var result = await _capacityRepo.DeleteAsync(pId);

            return result;
        }
    }
}
