using Autofac;
using CERAXLAN.Adesso.Business.ValidationRules.FluentValidation;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request.Travel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.DependencyResolvers.AutoFac
{
    public class ValidationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TravelValidator>().As<IValidator<CreateTravelRequestDTO>>().SingleInstance();
        }
    }
}
