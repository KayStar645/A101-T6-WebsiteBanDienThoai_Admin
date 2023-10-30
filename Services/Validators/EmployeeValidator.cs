using Domain.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
			RuleFor(x => x.Name)
			   .NotEmpty().WithMessage("Tên là bắt buộc.")
			   .MaximumLength(190).WithMessage("Tên không được vượt quá 190 ký tự.");

			RuleFor(x => x.Sex)
				.Must(gender => string.IsNullOrEmpty(gender) ||
								gender == "male" ||
								gender == "female" ||
								gender == "other")
				.WithMessage("Giới tính không hợp lệ.");

			RuleFor(x => x.Phone)
				.Must(phone => string.IsNullOrEmpty(phone) || phone.Length == 10)
				.WithMessage("Số điện thoại phải có 10 ký tự hoặc để trống.");
		}
    }
}
