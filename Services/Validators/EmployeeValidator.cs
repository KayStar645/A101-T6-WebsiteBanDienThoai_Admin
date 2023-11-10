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
                .Must(gender => string.IsNullOrEmpty(gender) || CommonTranform.GetGender().Contains(gender))
                .WithMessage(ValidatorTranform.Must("sex", CommonTranform.GetGender()));

            RuleFor(x => x.Birthday)
                .Must(dateOfBirth => string.IsNullOrEmpty(dateOfBirth.ToString()) ||
                                    CustomValidatorCommon.IsAtLeastNYearsOld(dateOfBirth, 16))
                .WithMessage(ValidatorTranform.MustDate(ModulesTransform.Common.DateOfBirth, 16));

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Employee.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Employee.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _employeeRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTranform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Employee.module));
        }
    }
}
