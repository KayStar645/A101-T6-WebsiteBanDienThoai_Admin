using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class SpecificationsValidator : AbstractValidator<SpecificationsDto>
    {
        private readonly ISpecificationsRepository _specificationsRepo;

        public SpecificationsValidator(ISpecificationsRepository specificationsRepo, int? pId = null)
        {
            _specificationsRepo = specificationsRepo;

            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Specifications.module))
               .MaximumLength(ValidatorCommon.NameLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Specifications.module, ValidatorCommon.NameLength))
               .MustAsync(async (name, token) =>
               {
                   return await _specificationsRepo.AnyKeyValueAsync(new[] { ("Name", name) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists(ModulesTransform.Common.Name +
                                        ModulesTransform.Specifications.module));
        }
    }
}
