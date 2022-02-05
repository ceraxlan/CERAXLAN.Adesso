using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request.Passenger;
using CERAXLAN.Adesso.Entities.Request.Travel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Abstract
{
    public interface IPassengerService
    {
        List<Passenger> GetAll();
        Passenger Add(JoinTravelRequestDTO request);
    }
}
