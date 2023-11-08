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

		public ColorValidator(IColorRepository colorRepository, bool? pIsCreate = true, int? pId = null)
		{
			_colorRepo = colorRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Color.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Color.module, ValidatorCommon.NameLength));

			if (pIsCreate == true)
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Color.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Color.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _colorRepo.AnyInternalCodeAsync(internalCode) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
			else
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Color.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Color.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _colorRepo.AnyInternalCodeAsync(internalCode, pId) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}

		}
	}
}
