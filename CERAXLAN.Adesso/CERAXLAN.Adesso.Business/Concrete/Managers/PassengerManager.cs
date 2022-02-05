using AutoMapper;
using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Core.Aspects.Postsharp.CacheAspects;
using CERAXLAN.Adesso.Core.CrossCuttingConcerns.Caching.Microsoft;
using CERAXLAN.Adesso.DataAccess.Abstract;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request.Passenger;
using CERAXLAN.Adesso.Entities.Request.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Concrete.Managers
{
    public class PassengerManager :IPassengerService
    {
        private readonly IPassengerDal _passengerDal;
        private readonly IMapper _mapper;
        public PassengerManager(IPassengerDal passengerDal, IMapper mapper)
        {
            _passengerDal = passengerDal;
            _mapper = mapper;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Passenger Add(JoinTravelRequestDTO request)
        {
            return _passengerDal.Add(_mapper.Map<Passenger>(request));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Passenger> GetAll()
        {
            return _passengerDal.GetList();
        }
    }
}
