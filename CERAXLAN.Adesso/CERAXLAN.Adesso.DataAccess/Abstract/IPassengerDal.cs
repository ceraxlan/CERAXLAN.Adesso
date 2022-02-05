using CERAXLAN.Adesso.Core.DataAccess;
using CERAXLAN.Adesso.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.DataAccess.Abstract
{
    public interface IPassengerDal : IEntityRepository<Passenger>
    {
    }
}
