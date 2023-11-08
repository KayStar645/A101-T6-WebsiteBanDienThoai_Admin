using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
	public class DetailSpecificationsValidator : AbstractValidator<DetailSpecificationsDto>
	{
		private readonly IDetailSpecificationsRepository _detailSpecificationsRepo;

		public DetailSpecificationsValidator(IDetailSpecificationsRepository detailSpecificationsRepository, bool? pIsCreate = true, int? pId = null)
		{
			_detailSpecificationsRepo = detailSpecificationsRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.DetailSpecifications.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.DetailSpecifications.module, ValidatorCommon.NameLength));

			RuleFor(x => x.Description)
				.NotEmpty().WithMessage(ValidatorTranform.Required("description"))
				.MaximumLength(6000).WithMessage(ValidatorTranform.MaximumLength("description", 6000));

		}
	}
}
