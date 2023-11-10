using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class DetailSpecificationsValidator : AbstractValidator<DetailSpecificationsDto>
    {
        private readonly IDetailSpecificationsRepository _detailSpecificationsRepo;

        public DetailSpecificationsValidator(IDetailSpecificationsRepository detailSpecificationsRepository, string pDescription, int? pId = null)
        {
            _detailSpecificationsRepo = detailSpecificationsRepository;

            RuleFor(x => x.Description)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.DetailSpecifications.value))
               .MaximumLength(ValidatorCommon.DescriptionLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.DetailSpecifications.value, ValidatorCommon.DescriptionLength));

            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.DetailSpecifications.module))
               .MaximumLength(ValidatorCommon.NameLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.DetailSpecifications.module, ValidatorCommon.NameLength))
               .MustAsync(async (name, token) =>
               {
                   return await _detailSpecificationsRepo.AnyKeyValueAsync(new[] { ("Name", name), ("Description", pDescription) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists(ModulesTransform.DetailSpecifications.obj));
        }
    }
}
