using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class CapacityValidator : AbstractValidator<CapacityDto>
    {
        private readonly ICapacityRepository _capacityRepo;

        public CapacityValidator(ICapacityRepository capacityRepo, bool? pIsCreate = true, int? pId = null) 
        {
            _capacityRepo = capacityRepo;

            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Capacity.module))
               .MaximumLength(ValidatorCommon.NameLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Capacity.module, ValidatorCommon.NameLength))
               .MustAsync(async (name, token) =>
               {
                   return await _capacityRepo.AnyKeyValueAsync(new[] { ("Name", name) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.Name +
                                        ModulesTransform.Capacity.module));
        }
    }
}
