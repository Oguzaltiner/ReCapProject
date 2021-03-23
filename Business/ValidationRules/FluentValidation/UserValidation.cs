using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidation : AbstractValidator<User>
    {
        public UserValidation()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
            RuleFor(p => p.Password).NotEmpty();
            RuleFor(p => p.Password).MaximumLength(16);
            RuleFor(p => p.Password).MinimumLength(4);
            RuleFor(p => p.Email).EmailAddress();
            RuleFor(p => p.Email).NotEmpty();

        }
    }
}
