using Database.Interfaces;
using Domain.DTOs;
using Domain.Entities;
using FluentValidation;
using Services.Common;
using Services.Transform;

namespace Services.Validators
{
    public class OrderValidator : AbstractValidator<OrderDto>
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IDetailOrderRepository _detailOrderRepo;

        public OrderValidator(IOrderRepository orderRepository, IDetailOrderRepository detailOrderRepository,
            bool? pIsCreate = true, int? pId = null)
        {
            _orderRepo = orderRepository;
            _detailOrderRepo = detailOrderRepository;

            RuleFor(x => x.InternalCode)
               .NotEmpty()
               .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Order.module))
               .MaximumLength(ValidatorCommon.InternalCodeLength)
               .WithMessage(ValidatorTransform.MaximumLength(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Order.module, ValidatorCommon.InternalCodeLength))
               .MustAsync(async (internalCode, token) =>
               {
                    return await _orderRepo.AnyKeyValueAsync(new[] { ("InternalCode", internalCode) }, pId) == false;
               })
               .WithMessage(internalCode => ValidatorTransform.Exists(ModulesTransform.Common.InternalCode +
                                        ModulesTransform.Order.module));

            RuleFor(x => x.Price)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Common.price))
                .Must(value => long.TryParse(value.ToString(), out _))
                .WithMessage(ValidatorTransform.MustLong(ModulesTransform.Common.price));

            RuleFor(x => x.Type)
                .Must(gender => string.IsNullOrEmpty(gender) || Order.GetTypeMapping().Select(x => x.type).Contains(gender))
                .WithMessage(ValidatorTransform.Must(ModulesTransform.Order.type, Order.GetTypeMapping().Select(x => x.type).ToArray()));

            RuleFor(x => x.Details)
                .NotEmpty()
                .WithMessage(ValidatorTransform.Required(ModulesTransform.Order.details));


            When(x => x.Details != null, () =>
            {
                RuleForEach(x => x.Details)
                    .SetValidator(new DetailOrderValidator(_detailOrderRepo));
            });
        }
    }
}
