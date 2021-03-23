using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidation : AbstractValidator<Rental>
    {
        public RentalValidation()
        {
            RuleFor(r => r.RentDate).NotEmpty();
        }
    }
}
