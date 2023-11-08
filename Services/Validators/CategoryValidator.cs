using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;


namespace Services.Validators
{
	public class CategoryValidator : AbstractValidator<CategoryDto>
	{
		private readonly ICategoryRepository _categoryRepo;

		public CategoryValidator(ICategoryRepository categoryRepository, bool? pIsCreate = true, int? pId = null)
		{
			_categoryRepo = categoryRepository;

			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage(ValidatorTranform.Required(ModulesTransform.Common.Name +
										ModulesTransform.Category.module))
				.MaximumLength(ValidatorCommon.NameLength)
				.WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
							 ModulesTransform.Category.module, ValidatorCommon.NameLength));

			if (pIsCreate == true)
			{
				RuleFor(x => x.InternalCode)
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Category.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Category.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _categoryRepo.AnyInternalCodeAsync(internalCode) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			}
			else
			{
				RuleFor(x => x.InternalCode) 
			   .NotEmpty()
			   .WithMessage(ValidatorTranform.Required(ModulesTransform.Common.InternalCode +
										ModulesTransform.Category.module))
			   .MaximumLength(ValidatorCommon.InternalCodeLength)
			   .WithMessage(ValidatorTranform.MaximumLength(ModulesTransform.Common.Name +
										ModulesTransform.Category.module, ValidatorCommon.InternalCodeLength))
			   .MustAsync(async (internalCode, token) =>
			   {
				   return await _categoryRepo.AnyInternalCodeAsync(internalCode, pId) == false;
			   })
			   .WithMessage(internalCode => ValidatorTranform.Exists("internalCode"));
			} 
		}
	}
}
