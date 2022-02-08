using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request;
using CERAXLAN.Adesso.Entities.Request.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Abstract
{
    public interface ITravelService
    {
        List<Travel> GetAll();
        Travel GetById(int id);
        Travel GetByIdWithPassengers(int id);
        List<Travel> FindTravel(FindTravelRequestDTO request);
        Travel Add(CreateTravelRequestDTO travel);
        Travel UpdateTravelStatus(UpdateTravelStatusRequestDTO request);
        //Travel UpdateTravelCapacity(JoinTravelRequestDTO request);
        List<Travel> GetTravelsByDriverId(int id);
    }
}
