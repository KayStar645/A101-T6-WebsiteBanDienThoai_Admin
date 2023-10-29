using Domain.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
			RuleFor(x => x.Phone)
				.Must(phone => string.IsNullOrEmpty(phone) || phone.Length == 10)
				.WithMessage("Số điện thoại phải có 10 ký tự hoặc để trống.");

			RuleFor(x => x.Name)
			   .NotEmpty().WithMessage("Tên là bắt buộc.")
			   .MaximumLength(190).WithMessage("Tên không được vượt quá 190 ký tự.");

			RuleFor(x => x.Address)
				.MaximumLength(300).WithMessage("Địa chỉ không được vượt quá 300 ký tự.");
		}
    }
}
