using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using Services.Common;
using Services.Transform;
using Color = Domain.Entities.Color;

namespace Services.Validators
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        private readonly IProductRepository _productRepo;
        private readonly IColorRepository _colorRepo;
        private readonly ICapacityRepository _capacityRepo;

        public ProductValidator(IProductRepository productRepository, IColorRepository colorRepository,
            ICapacityRepository capacity, int? pId = null)
        {
            _productRepo = productRepository;
            _colorRepo = colorRepository;
            _capacityRepo = capacity;

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Product.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Product.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _productRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Product.module));

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Product.module))
                .MaximumLength(ValidatorCommon.NameLength)
                .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                             ModulesTransform.Product.module, ValidatorCommon.NameLength));

            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.price))
                .Must(value => long.TryParse(value.ToString(), out _))
                .WithMessage(ValidatorTransform.MustLong(ModulesTransform.Common.price));

            RuleFor(x => x.ColorId)
               .MustAsync(async (colorId, token) =>
               {
                   if (colorId != 0 && colorId != null)
                   {
                       return await _colorRepo.AnyIdAsync<Color>((int)colorId) == false;
                   }
                   return false;
               })
               .WithMessage(userId => ValidatorTransform.MustIn(ModulesTransform.Product.color));

            RuleFor(x => x.CapacityId)
               .MustAsync(async (capacityId, token) =>
               {
                   if (capacityId != 0 && capacityId != null)
                   {
                       return await _capacityRepo.AnyIdAsync<Capacity>((int)capacityId) == false;
                   }
                   return true;
               })
               .WithMessage(userId => ValidatorTransform.MustIn(ModulesTransform.Product.capacity));

        }
    }
}
