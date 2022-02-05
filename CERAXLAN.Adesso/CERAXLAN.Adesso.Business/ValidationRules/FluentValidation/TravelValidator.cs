using CERAXLAN.Adesso.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.ValidationRules.FluentValidation
{
    public class TravelValidator : AbstractValidator<Travel>
    {
        public TravelValidator()
        {

            RuleFor(p => p.ToWhere).NotEqual("");
            RuleFor(p => p.WhereFrom).NotEmpty().NotEqual("");

        }
    }
}
