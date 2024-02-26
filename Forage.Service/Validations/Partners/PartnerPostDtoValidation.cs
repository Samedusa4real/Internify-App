using FluentValidation;
using Forage.Service.Dtos.Partners;
using Forage.Service.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Partners
{
    public class PartnerPostDtoValidation:AbstractValidator<PartnerPostDto>
    {
        public PartnerPostDtoValidation()
        {
			RuleFor(x => x.Name)
	  .NotEmpty()
	  .NotNull().WithMessage("Name can not be null")
	  .MinimumLength(2)
	  .MaximumLength(50);
			RuleFor(x => x)
	 .Custom((x, context) =>
	 {
		 if (x.file != null)
		 {
			 if (!Helper.isImage(x.file))
			 {
				 context.AddFailure("file", "The type of Logo must be image");
			 }
			 if (!Helper.isSizeOk(x.file, 2))
			 {
				 context.AddFailure("file", "The size of image less than 2 mb");
			 }
		 }
	 });
		}
    }
}
