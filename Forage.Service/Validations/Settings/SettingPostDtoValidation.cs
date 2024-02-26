using FluentValidation;
using Forage.Service.Dtos.Settings;
using Forage.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Settings
{
    public class SettingPostDtoValidation:AbstractValidator<SettingPostDto>
    {
        public SettingPostDtoValidation()
        {
            RuleFor(x => x.AboutText)
            .NotEmpty()
            .NotNull()
            .MinimumLength(100)
            .MaximumLength(300);
            RuleFor(x => x)
        .Custom((x, context) =>
        {
            if (x.Logo != null)
            {
                if (!Helper.isImage(x.Logo))
                {
                    context.AddFailure("Logo", "The type of Logo must be image");
                }
                if (!Helper.isSizeOk(x.Logo, 2))
                {
                    context.AddFailure("Logo", "The size of image less than 2 mb");
                }
            }
        });


            RuleFor(x => x)
    .Custom((x, context) =>
    {
        if (x.AboutImage != null)
        {
            if (!Helper.isImage(x.AboutImage))
            {
                context.AddFailure("AboutImage", "The type of file must be image");
            }
            if (!Helper.isSizeOk(x.AboutImage, 2))
            {
                context.AddFailure("AboutImage", "The size of image less than 2 mb");
            }
        }
    });

            RuleFor(x => x.Phone1)
           .NotEmpty()
           .NotNull().WithMessage("Phone1 can not be null");


            RuleFor(x => x.Address)
               .NotEmpty()
              .NotNull();

            RuleFor(x => x)
              .Custom((x, context) =>
              {
                  if (x.Email != null)
                  {
                      Regex re = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                      if (!re.IsMatch(x.Email))
                      {
                          context.AddFailure("email", "Email format must be correct");
                      }
                  }
                  else
                  {
                      context.AddFailure("email", "Email is required");
                  }
              }
              );
        }
    }
}
