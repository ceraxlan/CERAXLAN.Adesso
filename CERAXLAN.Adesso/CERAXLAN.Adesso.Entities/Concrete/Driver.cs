using CERAXLAN.Adesso.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Entities.Concrete
{
    public class Driver :IEntity
    {
        [Key]
        public int DriverId { get; set; }
        public string DriverUsername { get; set; }
    }
}
