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

		public SpecificationsValidator(ISpecificationsRepository specificationsRepository, bool? pIsCreate = true, int? pId = null)
		{
			_specificationsRepo = specificationsRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Specifications.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Specifications.module, ValidatorCommon.NameLength));

		}
	}
}
