using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
    public class DistributorValidator : AbstractValidator<Distributor>
    {
        public DistributorValidator()
        {
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Tên bắt buộc.")
				.MaximumLength(190).WithMessage("Tên không được vượt quá 190 ký tự.");

			RuleFor(x => x.Address)
				.MaximumLength(300).WithMessage("Địa chỉ không được vượt quá 300 ký tự.");

			RuleFor(x => x.Phone)
				.Must(phone => string.IsNullOrEmpty(phone) || phone.Length == 10)
				.WithMessage("Số điện thoại phải có 10 ký tự hoặc để trống.");
		}

    }
}
