using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using Services.Common;
using Services.Transform;
using Services.Validators.Common;

namespace Services.Validators
{
    public class PromotionValidator : AbstractValidator<PromotionDto>
    {
        private readonly IPromotionRepository _promotionRepo;

        public PromotionValidator(IPromotionRepository promotionRepository, DateTime pStart,
            string pType, bool? pIsCreate = true, int? pId = null)
        {
            _promotionRepo = promotionRepository;

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Promotion.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                                        ModulesTransform.Promotion.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                   return await _promotionRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Promotion.module));

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Name +
                                        ModulesTransform.Promotion.module))
                .MaximumLength(ValidatorCommon.NameLength)
                .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.Name +
                             ModulesTransform.Promotion.module, ValidatorCommon.NameLength));

            RuleFor(x => x.Start)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.start))
                .Must(start => CustomValidatorCommon.IsEqualOrAfterDay(start, DateTime.Now))
                .WithMessage(ValidatorTransform.GreaterEqualOrThanDay(ModulesTransform.Promotion.start, DateTime.Now));

            RuleFor(x => x.End)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.end))
                .Must(end => CustomValidatorCommon.IsAfterDay(end, pStart))
                .WithMessage(ValidatorTransform.GreaterThanDay(ModulesTransform.Promotion.end, pStart));

            RuleFor(x => x.Type)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.Type))
                .Must(type => Promotion.GetTypeMapping().Select(x => x.type).Contains(type))
                .WithMessage(ValidatorTransform.Must(ModulesTransform.Common.Type, Promotion.GetTypeMapping().Select(x => x.type).ToArray()));

            if(pType == Promotion.TYPE_DISCOUNT)
            {
                RuleFor(x => x.Discount)
                    .NotEmpty()
                    .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.discount))
                    .Must(discount => discount > 0)
                    .WithMessage(ValidatorTransform.GreaterThanOrEqualTo(ModulesTransform.Promotion.discount, 0));

                RuleFor(x => x.PercentMax)
                    .NotEmpty()
                    .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.percentMax))
                    .Must(percentMax => 0 < percentMax && percentMax <= 100)
                    .WithMessage(ValidatorTransform.GreaterThanAndLessThanOrEqualTo(ModulesTransform.Promotion.percentMax, 0, 100));
            }
            else if(pType == Promotion.TYPE_PERCENT)
            {
                RuleFor(x => x.Percent)
                    .NotEmpty()
                    .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.percent))
                    .Must(percent => 0 < percent && percent <= 100)
                    .WithMessage(ValidatorTransform.GreaterThanAndLessThanOrEqualTo(ModulesTransform.Promotion.percent, 0, 100));

                RuleFor(x => x.DiscountMax)
                    .NotEmpty()
                    .WithMessage(ValidatorTransform.Required(ModulesTransform.Promotion.discountMax))
                    .Must(discountMax => discountMax > 0)
                    .WithMessage(ValidatorTransform.GreaterThanOrEqualTo(ModulesTransform.Promotion.discountMax, 0));
            } 
        }
    }
}
