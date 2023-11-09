using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class EmployeeValidator : AbstractValidator<EmployeeDto>
    {
		private readonly IEmployeeRepository _employeeRepo;

		public EmployeeValidator(IEmployeeRepository employeeRepository, bool? pIsCreate = true, int? pId = null)
		{
			_employeeRepo = employeeRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Employee.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Employee.module, ValidatorCommon.NameLength));


			RuleFor(x => x.Phone)
			   .Must(phoneNumber => string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 10)
			   .WithMessage(ValidatorTranform.Length(ModulesTransform.Common.Phone,
													 ValidatorCommon.PhoneLength));

			RuleFor(x => x.Sex)
				.Must(gender => string.IsNullOrEmpty(gender) || gender == CommonTranform.male
							|| gender == CommonTranform.female || gender == CommonTranform.other)
				.WithMessage(ValidatorTranform.Must("sex", CommonTranform.GetGender()));

			RuleFor(x => x.Birthday)
				.Must(dateOfBirth => string.IsNullOrEmpty(dateOfBirth.ToString()) ||
									CommonCustomValidator.IsAtLeastNYearsOld(dateOfBirth, 16))
				.WithMessage(ValidatorTranform.MustDate("dateOfBirth", 16));

			if (pIsCreate == true)
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Employee.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Employee.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _employeeRepo.AnyInternalCodeAsync(internalCode) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
			else
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Employee.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Employee.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _employeeRepo.AnyInternalCodeAsync(internalCode, pId) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
		}
	}
}
