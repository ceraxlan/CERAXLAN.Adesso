using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.DependencyResolvers.AutoFac
{
    public class AutoMapperModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.Register(c => new MapperConfiguration(cfg =>
            {
                cfg.AddProfiles(GetType().Assembly);
            }).CreateMapper()).As<IMapper>().SingleInstance();

        }
    }
}
