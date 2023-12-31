﻿using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Interfaces.Common;
using Services.Middleware;
using Services.Transform;
using Services.Validators;

namespace Services.Services
{
    public class DistributorService : IDistributorService, IService
    {
        private readonly IDistributorRepository _distributorRepo;
        private readonly IMapper _mapper;

        public DistributorService(IDistributorRepository distributorRepository, IMapper mapper)
        {
            _distributorRepo = distributorRepository;
            _mapper = mapper;
        }

        [RequirePermission("Distributor.View")]
        public async Task<(List<DistributorDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission("Distributor.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }

            var result = await _distributorRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<DistributorDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Distributor.View")]
        public async Task<DistributorDto> GetDetail(int pId)
        {
            if (CustomMiddleware.CheckPermission("Distributor.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var distributor = await _distributorRepo.GetDetailAsync(pId);

            var distributorDto = _mapper.Map<DistributorDto>(distributor);

            return distributorDto;
        }

        [RequirePermission("Distributor.Create")]
        public async Task<bool> Create(DistributorDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Distributor.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
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

        [RequirePermission("Distributor.Update")]
        public async Task<bool> Update(DistributorDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Distributor.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }

            DistributorValidator validator = new DistributorValidator(_distributorRepo, false, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            Distributor distributor = _mapper.Map<Distributor>(pUpdate);

            var result = await _distributorRepo.UpdateAsync(distributor);

            return result > 0;
        }

        [RequirePermission("Distributor.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Distributor.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _distributorRepo.DeleteAsync(pId);

            return result;
        }
    }
}
