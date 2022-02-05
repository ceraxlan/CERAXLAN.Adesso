using AutoMapper;
using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Core.Aspects.Postsharp.CacheAspects;
using CERAXLAN.Adesso.Core.CrossCuttingConcerns.Caching.Microsoft;
using CERAXLAN.Adesso.DataAccess.Abstract;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CERAXLAN.Adesso.Business.Concrete.Managers
{
    public class DriverManager : IDriverService
    {
        private readonly IDriverDal _driverDal;
        private readonly IMapper _mapper;

        public DriverManager(IDriverDal driverDal, IMapper mapper)
        {
            _driverDal = driverDal;
            _mapper = mapper;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public Driver Add(CreateDriverRequestDTO request)
        {
            return _driverDal.Add(_mapper.Map<Driver>(request));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Driver> GetAll()
        {
            return _driverDal.GetList();
        }
    }
}
