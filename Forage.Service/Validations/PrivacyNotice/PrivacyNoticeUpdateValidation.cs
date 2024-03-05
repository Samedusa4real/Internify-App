using FluentValidation;
using Forage.Service.Dtos.PrivacyNotice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Validations.PrivacyNotice
{
    public class PrivacyNoticeUpdateValidation : AbstractValidator<PrivacyNoticeUpdateDto>
    {
        public PrivacyNoticeUpdateValidation()
        {
            RuleFor(x => x.Text)
            .NotEmpty()
            .NotNull().WithMessage("Text can not be null")
            .MinimumLength(250);
        }
    }
}
