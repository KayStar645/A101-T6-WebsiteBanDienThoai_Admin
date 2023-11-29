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
    public class DetailSpecificationsService : IDetailSpecificationsService, IService
    {
        private readonly IDetailSpecificationsRepository _detailSpecificationsRepo;
        private readonly IMapper _mapper;

        public DetailSpecificationsService(IDetailSpecificationsRepository detailSpecificationsRepository, IMapper mapper)
        {
            _detailSpecificationsRepo = detailSpecificationsRepository;
            _mapper = mapper;
        }

        [RequirePermission("Specifications.View")]
        public async Task<List<DetailSpecificationsDto>> GetListBySpecificationsIdAsync(int pSpecificationsId)
        {
            if (CustomMiddleware.CheckPermission("Specifications.View") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _detailSpecificationsRepo.GetBySpecificationsIdAsync(pSpecificationsId);

            var list = _mapper.Map<List<DetailSpecificationsDto>>(result);

            return list;
        }

        [RequirePermission("Specifications.Create")]
        public async Task<bool> Create(DetailSpecificationsDto pCreate)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Create") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            DetailSpecificationsValidator validator = new DetailSpecificationsValidator(_detailSpecificationsRepo, pCreate.Description);
            var validationResult = await validator.ValidateAsync(pCreate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var detailSpecifications = _mapper.Map<DetailSpecifications>(pCreate);

            var result = await _detailSpecificationsRepo.AddAsync(detailSpecifications);

            return result > 0;
        }

        [RequirePermission("Specifications.Update")]
        public async Task<bool> Update(DetailSpecificationsDto pUpdate)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Update") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            DetailSpecificationsValidator validator = new DetailSpecificationsValidator(_detailSpecificationsRepo, pUpdate.Description, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

            var detailSpecifications = _mapper.Map<DetailSpecifications>(pUpdate);

            var result = await _detailSpecificationsRepo.UpdateAsync(detailSpecifications);

            return result > 0;
        }

        [RequirePermission("Specifications.Delete")]
        public async Task<bool> Delete(int pId)
        {
            if (CustomMiddleware.CheckPermission("Specifications.Delete") == false)
            {
                throw new UnauthorizedAccessException(IdentityTransform.ForbiddenException());
            }
            var result = await _detailSpecificationsRepo.DeleteAsync(pId);

            return result;
        }
    }
}
