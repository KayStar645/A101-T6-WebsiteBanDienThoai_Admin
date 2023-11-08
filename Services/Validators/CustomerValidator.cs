﻿using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
		private readonly ICustomerRepository _customerRepo;

		public CustomerValidator(ICustomerRepository customerRepository, bool? pIsCreate = true, int? pId = null)
		{
			_customerRepo = customerRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Customer.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Customer.module, ValidatorCommon.NameLength));

			RuleFor(x => x.Address)
				.MaximumLength(ValidatorCommon.AddressLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Address,
															 ValidatorCommon.AddressLength));

			RuleFor(x => x.Phone)
			   .Must(phoneNumber => string.IsNullOrEmpty(phoneNumber) || phoneNumber.Length == 10)
			   .WithMessage(ValidatorTranform.Length(ModulesTransform.Common.Phone,
													 ValidatorCommon.PhoneLength));

			if (pIsCreate == true)
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Customer.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Customer.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _customerRepo.AnyInternalCodeAsync(internalCode) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
			else
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Customer.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Customer.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _customerRepo.AnyInternalCodeAsync(internalCode, pId) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
		}
	}
}
