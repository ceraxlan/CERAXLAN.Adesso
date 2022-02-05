using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Entities.Request.Travel
{
    public class CreateTravelRequestDTO
    {
        public string WhereFrom { get; set; }
        public string ToWhere { get; set; }
        public DateTime StartDate { get; set; }
        public string Explanation { get; set; }
        public int MaxSeatingCapacity { get; set; }
        public int DriverId { get; set; } 
    }
}
