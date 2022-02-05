using AutoMapper;
using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Business.ValidationRules.FluentValidation;
using CERAXLAN.Adesso.Core.Aspects.Postsharp.CacheAspects;
using CERAXLAN.Adesso.Core.Aspects.Postsharp.ValidationAspects;
using CERAXLAN.Adesso.Core.CrossCuttingConcerns.Caching.Microsoft;
using CERAXLAN.Adesso.DataAccess.Abstract;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request;
using CERAXLAN.Adesso.Entities.Request.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Concrete.Managers
{
    public class TravelManager : ITravelService
    {
        private readonly ITravelDal _travelDal;
        private readonly IPassengerDal _passengerDal;
        private readonly IMapper _mapper;

        public TravelManager(ITravelDal travelDal, IMapper mapper, IPassengerDal passengerDal)
        {
            _travelDal = travelDal;
            _mapper = mapper;
            _passengerDal = passengerDal;
        }

        [FluentValidationAspect(typeof(TravelValidator))]
        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Travel Add(CreateTravelRequestDTO travel)
        {
            return _travelDal.Add(_mapper.Map<Travel>(travel));
        }

        public List<Travel> FindTravel(FindTravelRequestDTO request)
        {
            return _travelDal.GetList(t=>(t.ToWhere==request.ToWhere & t.WhereFrom==request.WhereFrom) & t.TravelStatus==true);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Travel> GetAll()
        {
            return _travelDal.GetList();
        }

        public Travel GetById(int id)
        {
            return _travelDal.Get(t=>t.TravelId == id);
        }

        public List<Travel> GetTravelsByDriverId(int id)
        {
            return _travelDal.GetList(t=>t.DriverId==id);
        }

        //public Travel UpdateTravelCapacity(JoinTravelRequestDTO request)
        //{
        //    var travel = GetById(request.TravelId);
        //    if(travel.MaxSeatingCapacity > travel.CurrentSeatingCapacity && travel.TravelStatus==true)
        //    {
        //        travel.CurrentSeatingCapacity++;
        //        var passenger = _passengerDal.Get(p=>p.PassengerId==request.PassengerId);
        //        travel.Passengers.Add(passenger);
        //        return _travelDal.Update(travel);
        //    }
        //    return travel;
        //}

        public Travel UpdateTravelStatus(UpdateTravelStatusRequestDTO request)
        {
            var travel = GetById(request.TravelId);
            if(travel.DriverId == request.DriverId) {
                travel.TravelStatus = request.TravelStatus;
                return _travelDal.Update(travel);
            }
            return travel;
        }
    }
}
