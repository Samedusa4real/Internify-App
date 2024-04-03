using FluentValidation;
using Forage.Service.Dtos.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Contacts
{
    public class ContactPostDtoValidation:AbstractValidator<ContactPostDto>
    {
        public ContactPostDtoValidation()
        {
            RuleFor(x => x.FullName)
                .NotEmpty()
                .NotNull().WithMessage("Name can not be null")
                .MaximumLength(25);

            RuleFor(x => x)
                .Custom((x, context) =>
                {
                    if (x.Email != null)
                    {
                        Regex re = new Regex("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                        if (!re.IsMatch(x.Email))
                        {
                            context.AddFailure("Email", "Email format must be correct");
                        }
                    }
                    else
                    {
                        context.AddFailure("Email", "Email is required");
                    }
                });

            RuleFor(x => x.Message)
                .NotEmpty()
                .NotNull().WithMessage("Message can not be empty")
                .MaximumLength(500);
        }
    }
}
