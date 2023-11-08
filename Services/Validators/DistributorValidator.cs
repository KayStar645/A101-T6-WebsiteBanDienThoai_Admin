using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class DistributorValidator : AbstractValidator<DistributorDto>
    {
        private readonly IDistributorRepository _distributorRepo;

        public DistributorValidator(IDistributorRepository distributorRepository, bool? pIsCreate = true, int? pId = null)
        {
            _distributorRepo = distributorRepository;

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Distributor.module))
                .MaximumLength(ValidatorCommon.NameLength)
                .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                             ModulesTransform.Distributor.module, ValidatorCommon.NameLength));

            RuleFor(x => x.Address)
                .MaximumLength(ValidatorCommon.AddressLength)
                .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Address,
                                                             ValidatorCommon.AddressLength));

            RuleFor(x => x.Phone)
               .Must(phoneNumber => string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 10)
               .WithMessage(ValidatorTranform.Length(ModulesTransform.Common.Phone,
                                                     ValidatorCommon.PhoneLength));

            if (pIsCreate == true)
            {
                RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Distributor.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Distributor.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _distributorRepo.AnyInternalCodeAsync(internalCode) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
            }    
            else
            {
                RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Distributor.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Distributor.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _distributorRepo.AnyInternalCodeAsync(internalCode, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
            } 
        }

    }
}
