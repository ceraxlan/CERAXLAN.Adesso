using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request.Travel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.ValidationRules.FluentValidation
{
    public class TravelValidator : AbstractValidator<CreateTravelRequestDTO>
    {
        public TravelValidator()
        {

            RuleFor(p => p.ToWhere).NotEqual("").WithMessage("This field cannot be left blank");
            RuleFor(p => p.ToWhere).NotNull().WithMessage("This field cannot be left blank");
            RuleFor(p => p.ToWhere).NotEmpty().WithMessage("This field cannot be left blank");
            RuleFor(p => p.WhereFrom).NotEmpty().NotEqual("").WithMessage("This field cannot be left blank"); 

        }
    }
}
