using AutoMapper;
using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using Services.Interfaces;
using Services.Validators;

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

        public async Task<List<DetailSpecificationsDto>> GetListBySpecificationsIdAsync(int pSpecificationsId)
        {
            var result = await _detailSpecificationsRepo.GetBySpecificationsIdAsync(pSpecificationsId);

            var list = _mapper.Map<List<DetailSpecificationsDto>>(result);

            return list;
        }

        public async Task<bool> Create(DetailSpecificationsDto pCreate)
        {
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

        public async Task<bool> Update(DetailSpecificationsDto pUpdate)
        {
            DetailSpecificationsValidator validator = new DetailSpecificationsValidator(_detailSpecificationsRepo, pUpdate.Description, pUpdate.Id);
            var validationResult = await validator.ValidateAsync(pUpdate);

            if (validationResult.IsValid == false)
            {
                var errorMessages = validationResult.Errors.Select(x => x.ErrorMessage).FirstOrDefault();
                throw new Exception(errorMessages);
            }

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
