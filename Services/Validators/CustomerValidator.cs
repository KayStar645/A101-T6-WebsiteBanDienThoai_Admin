using Domain.Entities;
using FluentValidation;

namespace Services.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator() 
        {
            
        }
    }
}
