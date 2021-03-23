using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidation : AbstractValidator<Brand>
    {
        public BrandValidation()
        {
            RuleFor(b => b.BrandId).NotEmpty();
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
            RuleFor(b => b.BrandName).Must(MustName);
        }

        private bool MustName(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
