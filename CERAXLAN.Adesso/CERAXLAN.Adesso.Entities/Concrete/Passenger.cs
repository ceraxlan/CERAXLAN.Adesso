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
    public class Passenger : IEntity
    {
        [Key]
        public int PassengerId { get; set; }       
        public string PassengerUsername { get; set; }
        public int? TravelId { get; set; }
        
    }
}
