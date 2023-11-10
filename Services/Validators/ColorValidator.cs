using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class ColorValidator : AbstractValidator<ColorDto>
    {
        private readonly IColorRepository _colorRepo;

        public ColorValidator(IColorRepository colorRepo, bool? pIsCreate = true, int? pId = null) 
        {
            _colorRepo = colorRepo;

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Color.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Color.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _colorRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Color.module));


            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Color.module))
               .MaximumLength(ValidatorCommon.NameLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Color.module, ValidatorCommon.NameLength))
               .MustAsync(async (name, token) =>
               {
                   return await _colorRepo.AnyKeyValueAsync(new[] { ("Name", name) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists(ModulesTransform.Common.Name +
                                        ModulesTransform.Color.module));
        }
    }
}
