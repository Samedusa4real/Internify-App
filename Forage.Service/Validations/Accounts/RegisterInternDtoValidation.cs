using FluentValidation;
using Forage.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Accounts
{
    public class RegisterInternDtoValidation:AbstractValidator<RegisterInternDto>
    {
        public RegisterInternDtoValidation()
        {
            RuleFor(x => x.FullName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("FullName is required")
                .NotNull().WithMessage("FullName is required")
                .Matches(@"^[a-zA-Z\s]+$").WithMessage("FullName should only contain letters and spaces");

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
                });

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required")
                .NotNull().WithMessage("Password is required");

            RuleFor(x => x)
                .Custom((x, context) =>
                {
                    if (x.PhoneNumber != null)
                    {
                        Regex re = new Regex(@"^\+994\s?((50|51|55|70|77)\s?\d{3}\s?\d{2}\s?\d{2})$");
                        if (!re.IsMatch(x.PhoneNumber))
                        {
                            context.AddFailure("PhoneNumber", "Invalid phone number for Azerbaijan");
                        }
                    }
                    else
                    {
                        context.AddFailure("PhoneNumber", "PhoneNumber is required");
                    }
                });

            RuleFor(x => x.FinNumber)
                .NotEmpty().WithMessage("FinNumber is required")
                .NotNull().WithMessage("FinNumber is required")
                .Length(7).WithMessage("Wrong FinNumber");
        }
    }
}
