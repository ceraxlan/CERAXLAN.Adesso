using AutoMapper;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request;
using CERAXLAN.Adesso.Entities.Request.Driver;
using CERAXLAN.Adesso.Entities.Request.Passenger;
using CERAXLAN.Adesso.Entities.Request.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Mappings.AutoMapper.Profiles
{
    public class BusinessProfile : Profile
    {
        public BusinessProfile()
        {
           
            CreateMap<CreateTravelRequestDTO, Travel>();
            CreateMap<CreateDriverRequestDTO, Driver>();
            CreateMap<JoinTravelRequestDTO, Passenger>();
            CreateMap<CreatePassengerRequestDTO, Passenger>();



        }
    }
}
