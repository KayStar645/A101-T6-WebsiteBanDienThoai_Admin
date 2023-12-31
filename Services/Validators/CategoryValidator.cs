﻿using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoryValidator(ICategoryRepository CategoryRepo, bool? pIsCreate = true, int? pId = null)
        {
            _categoryRepo = CategoryRepo;

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Category.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Category.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _categoryRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Category.module));


            RuleFor(x => x.Name)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Category.module))
               .MaximumLength(ValidatorCommon.NameLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Category.module, ValidatorCommon.NameLength))
               .MustAsync(async (name, token) =>
               {
                   return await _categoryRepo.AnyKeyValueAsync(new[] { ("Name", name) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.Name +
                                        ModulesTransform.Category.module));
        }
    }
}
