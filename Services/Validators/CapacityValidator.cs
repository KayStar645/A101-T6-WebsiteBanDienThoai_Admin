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

		public CapacityValidator(ICapacityRepository capacityRepository, bool? pIsCreate = true, int? pId = null)
		{
			_capacityRepo = capacityRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Capacity.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Capacity.module, ValidatorCommon.NameLength));

		}
	}
}
