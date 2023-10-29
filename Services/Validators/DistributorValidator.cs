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
        public DistributorValidator() { }
    }
}
