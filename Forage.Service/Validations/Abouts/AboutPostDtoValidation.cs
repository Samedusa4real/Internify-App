using FluentValidation;
using Forage.Service.Dtos.Abouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forage.Service.Validations.Abouts
{
    public class AboutPostDtoValidation : AbstractValidator<AboutPostDto>
    {
        public AboutPostDtoValidation()
        {
            
        }
    }
}
