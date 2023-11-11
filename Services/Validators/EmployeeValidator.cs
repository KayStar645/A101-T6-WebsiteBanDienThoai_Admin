using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;
using Services.Validators.Common;

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
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Employee.module))
                .MaximumLength(ValidatorCommon.NameLength)
                .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                             ModulesTransform.Employee.module, ValidatorCommon.NameLength));


            RuleFor(x => x.Phone)
               .Must(phoneNumber => string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 10)
               .WithMessage(ValidatorTransform.Length(ModulesTransform.Common.Phone,
                                                     ValidatorCommon.PhoneLength));

            RuleFor(x => x.Sex)
                .Must(gender => string.IsNullOrEmpty(gender) || CommonTransform.GetGender().Contains(gender))
                .WithMessage(ValidatorTransform.Must("sex", CommonTransform.GetGender()));

            RuleFor(x => x.Birthday)
                .Must(dateOfBirth => string.IsNullOrEmpty(dateOfBirth.ToString()) ||
                                    CustomValidatorCommon.IsAtLeastNYearsOld(dateOfBirth, 16))
                .WithMessage(ValidatorTransform.MustDate(ModulesTransform.Common.DateOfBirth, 16));

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Employee.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Employee.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _employeeRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Employee.module));
        }
    }
}
