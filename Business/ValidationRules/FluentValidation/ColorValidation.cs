using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidation : AbstractValidator<Color>
    {
        public ColorValidation()
        {
            RuleFor(c => c.ColorName).NotEmpty();
            RuleFor(c => c.ColorName).MinimumLength(2);
            RuleFor(c => c.ColorName).MinimumLength(16);
            RuleFor(c => c.ColorId).NotEmpty();
        }
    }
}
