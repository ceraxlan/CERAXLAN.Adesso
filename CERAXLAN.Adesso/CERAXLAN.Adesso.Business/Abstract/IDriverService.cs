using CERAXLAN.Adesso.Entities.Request.Driver;
using CERAXLAN.Adesso.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Abstract
{
    public interface IDriverService
    {
        List<Driver> GetAll();
        Driver Add(CreateDriverRequestDTO request);


    }
}
