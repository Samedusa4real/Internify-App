﻿using FluentValidation;
using Forage.Service.Dtos.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Accounts
{
    public class RegisterPartnerDtoValidation:AbstractValidator<RegisterPartnerDto>
    {
        public RegisterPartnerDtoValidation()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("User Name is required")
                .NotNull().WithMessage("User Name is required");

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
        }
    }
}
