using AutoMapper;
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
    public class SpecificationsService : ISpecificationsService, IService
    {
        private readonly ISpecificationsRepository _specificationsRepo;
        private readonly IMapper _mapper;

        public SpecificationsService(ISpecificationsRepository specificationsRepository, IMapper mapper)
        {
            _specificationsRepo = specificationsRepository;
            _mapper = mapper;
        }

        [RequirePermission("Specifications.View")]
        public async Task<(List<SpecificationsDto> list, int totalCount, int pageNumber)> GetList(string? pSort = "Id", int? pPageNumber = 1, int? pPageSize = 30, string? pKeyword = "")
        {
            if (CustomMiddleware.CheckPermission("Specifications.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _specificationsRepo.GetAllAsync(null, pKeyword, pSort, pPageNumber, pPageSize);

            var list = _mapper.Map<List<SpecificationsDto>>(result.list);

            return (list, result.totalCount, result.pageNumber);
        }

        [RequirePermission("Specifications.Create")]
        public async Task<int> Create(SpecificationsDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }

            SpecificationsValidator validator = new SpecificationsValidator(_specificationsRepo);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var specifications = _mapper.Map<Specifications>(pCreate);

            var result = await _specificationsRepo.AddAsync(specifications);

            return result;
        }

        [RequirePermission("Specifications.Update")]
        public async Task<bool> Update(SpecificationsDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            SpecificationsValidator validator = new SpecificationsValidator(_specificationsRepo, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var specifications = _mapper.Map<Specifications>(pUpdate);

            var result = await _specificationsRepo.UpdateAsync(specifications);

            return result > 0;
        }

        [RequirePermission("Specifications.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _specificationsRepo.DeleteAsync(pId);

            return result;
        }
    }
}
