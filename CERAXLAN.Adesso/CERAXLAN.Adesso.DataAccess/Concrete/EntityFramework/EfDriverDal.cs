using CERAXLAN.Adesso.Core.DataAccess.EntityFramework;
using CERAXLAN.Adesso.DataAccess.Abstract;
using CERAXLAN.Adesso.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.DataAccess.Concrete.EntityFramework
{
    public class EfDriverDal : EfEntityRepositoryBase<Driver, DatabaseContext>, IDriverDal
    {
    }
}
