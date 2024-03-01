using FluentValidation;
using Forage.Service.Dtos.Interns;
using Forage.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Interns
{
    public class InternPostDtoValidation:AbstractValidator<InternPostDto>
    {
        public InternPostDtoValidation()
        {
            RuleFor(x => x.Name)
            .NotEmpty()
            .NotNull().WithMessage("Name can not be null")
            .MinimumLength(3)
            .MaximumLength(30);
            RuleFor(x => x.Surname)
      .NotEmpty()
      .NotNull().WithMessage("Surname can not be null")
      .MinimumLength(3)
      .MaximumLength(30);
            RuleFor(x => x.FinNumber)
 .NotEmpty()
 .NotNull().WithMessage("FinNumber Length is 7")
 .MinimumLength(7)
 .MaximumLength(7);
            RuleFor(x => x)
               .Custom((x, context) =>
               {
                   if (x.Image != null)
                   {
                       if (!Helper.isImage(x.Image))
                       {
                           context.AddFailure("Image", "The type of file must be image");
                       }
                       if (!Helper.isSizeOk(x.Image, 2))
                       {
                           context.AddFailure("Image", "The size of image less than 2 mb");
                       }
                   }

               });
            RuleFor(x => x.AppUserId)
  .NotEmpty()
  .NotNull();
        }
    }
}
