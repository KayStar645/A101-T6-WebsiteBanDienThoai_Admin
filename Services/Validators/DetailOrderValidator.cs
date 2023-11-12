using Database.Interfaces;
using Domain.DTOs;
using FluentValidation;
using Services.Transform;

namespace Services.Validators
{
    public class DetailOrderValidator : AbstractValidator<DetailOrderDto>
    {
        private readonly IDetailOrderRepository _detailOrderRepo;

        public DetailOrderValidator(IDetailOrderRepository detailOrderRepository)
        {
            _detailOrderRepo = detailOrderRepository;

            RuleFor(x => x.Quantity)
                    .NotEmpty()
                    .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.quantity))
                    .Must(discount => discount > 0)
                    .WithMessage(ValidatorTransform.GreaterThanOrEqualTo(ModulesTransform.Common.quantity, 0));

            RuleFor(x => x.Price)
                   .NotEmpty()
                   .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.price))
                   .Must(discount => discount > 0)
                   .WithMessage(ValidatorTransform.GreaterThanOrEqualTo(ModulesTransform.Common.price, 0));
        }
    }
}
