using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CommenterValidator : AbstractValidator<Commenter>
    {
        public CommenterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Boş ola bilməz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Boş ola bilməz");
            RuleFor(x => x.ID).NotEmpty().WithMessage("Email Boş ola bilməz");
 
        }

    }
}