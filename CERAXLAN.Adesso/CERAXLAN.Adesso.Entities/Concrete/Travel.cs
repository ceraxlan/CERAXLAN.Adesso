using CERAXLAN.Adesso.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Entities.Concrete
{
    public class Travel :IEntity
    {
        [Key]
        public int TravelId { get; set; }
        public string WhereFrom { get; set; }
        public string ToWhere { get; set; }
        public DateTime StartDate { get; set; }
        public string Explanation { get; set; }
        public int CurrentSeatingCapacity { get; set; } = 0;
        public int MaxSeatingCapacity { get; set; } 
        public bool TravelStatus { get; set; } = true;
        public int DriverId { get; set; }     
        public ICollection<Passenger> Passengers { get; set; }
    }
}
