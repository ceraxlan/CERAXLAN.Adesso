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
        private readonly ITravelDal _travelDal;
        public PassengerManager(IPassengerDal passengerDal, IMapper mapper, ITravelDal travelDal)
        {
            _passengerDal = passengerDal;
            _mapper = mapper;
            _travelDal = travelDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Passenger Add(JoinTravelRequestDTO request)
        {
            return _passengerDal.Add(_mapper.Map<Passenger>(request));
        }

        public Passenger Add(CreatePassengerRequestDTO request)
        {
            return _passengerDal.Add(_mapper.Map<Passenger>( request));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Passenger> GetAll()
        {
            return _passengerDal.GetList();
        }

        public Passenger JoinToTravel(JoinTravelRequestDTO request)
        {
            var passenger = _passengerDal.Get(p=>p.PassengerId==request.PassengerId);
            var travel = _travelDal.Get(t=>t.TravelId==request.TravelId);
            if (travel.Passengers.Count() < travel.MaxSeatingCapacity)
            {               
                passenger.TravelId = request.TravelId;
                return _passengerDal.Update(passenger);
            }
            return passenger;
            
        }

        public Passenger LeaveFromTravel(int passengerId)
        {
            var passenger = _passengerDal.Get(p=>p.PassengerId == passengerId);
            passenger.TravelId = null;
            return _passengerDal.Update(passenger);
        }
    }
}
