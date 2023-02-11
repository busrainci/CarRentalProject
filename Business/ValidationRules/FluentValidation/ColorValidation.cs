using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation :AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(c => c.ColorName).Must(StartWithS).WithMessage("Renkler S harfi ile başlamalıdır.");
            RuleFor(c => c.ColorId).LessThanOrEqualTo(3); 
        }

        private bool StartWithS(string arg)
        {
            return arg.StartsWith("S");
        }
    }
}
