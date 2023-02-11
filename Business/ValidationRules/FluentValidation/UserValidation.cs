using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation:AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(u => u.UserId).GreaterThanOrEqualTo(1);
            RuleFor(u => u.UserFirstName).NotEmpty();
            RuleFor(u => u.UserLastName).NotEmpty();
            RuleFor(u => u.UserEmail).NotEmpty();
        }
    }
}
