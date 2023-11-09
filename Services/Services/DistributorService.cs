using AutoMapper;
using Azure.Core;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using Services.Interfaces;
using Services.Validators;
using System.ComponentModel.DataAnnotations;
using System.Net;

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
            DistributorValidator validator = new DistributorValidator(_distributorRepo, true);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            Distributor distributor = _mapper.Map<Distributor>(pCreate);

            var result = await _distributorRepo.AddAsync(distributor);

            return result > 0;
        }

        public async Task<bool> Update(DistributorDto pUpdate)
        {

            DistributorValidator validator = new DistributorValidator(_distributorRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            Distributor distributor = _mapper.Map<Distributor>(pUpdate);

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
