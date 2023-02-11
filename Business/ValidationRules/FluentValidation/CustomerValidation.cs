using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidation:AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.CompanyName).Length(2);
        }
    }
}
