using Autofac;
using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Business.Concrete.Managers;
using CERAXLAN.Adesso.Core.DataAccess;
using CERAXLAN.Adesso.Core.DataAccess.EntityFramework;
using CERAXLAN.Adesso.DataAccess.Abstract;
using CERAXLAN.Adesso.DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.DependencyResolvers.AutoFac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<TravelManager>().As<ITravelService>().SingleInstance();
            builder.RegisterType<EfTravelDal>().As<ITravelDal>();//EF or NH 

            builder.RegisterType<DriverManager>().As<IDriverService>().SingleInstance();
            builder.RegisterType<EfDriverDal>().As<IDriverDal>();//EF or NH 

            builder.RegisterType<PassengerManager>().As<IPassengerService>().SingleInstance();
            builder.RegisterType<EfPassengerDal>().As<IPassengerDal>();//EF or NH 

            //builder.RegisterType<LogManager>().As<ILogService>().SingleInstance();
            //builder.RegisterType<EfLogDal>().As<ILogDal>();//EF or NH 


            builder.RegisterGeneric(typeof(EfQueryableRepository<>)).As(typeof(IQueryableRepository<>));//EF or NH 
            builder.RegisterType<DatabaseContext>().As<DbContext>();
            
        }
    }
}
