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
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Distributor.module))
                .MaximumLength(ValidatorCommon.NameLength)
                .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                             ModulesTransform.Distributor.module, ValidatorCommon.NameLength));

            RuleFor(x => x.Address)
                .MaximumLength(ValidatorCommon.AddressLength)
                .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Address,
                                                             ValidatorCommon.AddressLength));

            RuleFor(x => x.Phone)
               .Must(phoneNumber => string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 10)
               .WithMessage(ValidatorTransform.Length(ModulesTransform.Common.Phone,
                                                     ValidatorCommon.PhoneLength));

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Distributor.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Distributor.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _distributorRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Distributor.module));
        }

    }
}
