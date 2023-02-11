using Entities.Concrete;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).Length(2);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(300).When(c => c.BrandId == 3);
            RuleFor(c => c.ModelYear).LessThanOrEqualTo("2020").When(c => c.ColorId == 2);
            RuleFor(c => c.Description).Length(10);

        }
    }
}
