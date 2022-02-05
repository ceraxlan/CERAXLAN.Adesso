using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Entities.Request.Driver;
using CERAXLAN.Adesso.Entities.Request.Travel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CERAXLAN.Adesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly IDriverService _driverService;
        private readonly ITravelService _travelService;

        public DriversController(IDriverService driverService, ITravelService travelService)
        {
            _driverService = driverService;
            _travelService = travelService;
        }

        [HttpGet("GetDrivers")]
        public IActionResult GetDrivers()
        {
            return Ok(_driverService.GetAll());
        }

        [HttpPost("AddDriver")]
        public IActionResult AddDriver(CreateDriverRequestDTO request)
        {
            return Ok(_driverService.Add(request));
        }

        [HttpPost("CreateTravel")]
        public IActionResult CreateTravel(CreateTravelRequestDTO travel)
        {
            return Ok(_travelService.Add(travel));
        }

        
        [HttpPost("GetMyTravels")]
        public IActionResult GetMyTravels(int id)
        {
            return Ok(_travelService.GetTravelsByDriverId(id));
        }

        [HttpPut("UpdateTravelStatus")]
        public IActionResult UpdateTravelStatus(UpdateTravelStatusRequestDTO request)
        {
            return Ok(_travelService.UpdateTravelStatus(request));
        }
    }
}
