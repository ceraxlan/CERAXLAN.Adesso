using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Entities.Request.Travel
{
    public class UpdateTravelStatusRequestDTO
    {
        public int DriverId { get; set; }
        public int TravelId { get; set; }
        public bool TravelStatus { get; set; } = true;
    }
}
