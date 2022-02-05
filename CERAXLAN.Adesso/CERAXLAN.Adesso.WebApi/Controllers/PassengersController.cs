using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Entities.Request.Passenger;
using CERAXLAN.Adesso.Entities.Request.Travel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CERAXLAN.Adesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        private readonly IPassengerService _passengerService;
        private readonly ITravelService _travelService;

        public PassengersController(IPassengerService passengerService, ITravelService travelService)
        {
            _passengerService = passengerService;
            _travelService = travelService;
        }

        [HttpGet("GetPassengers")]
        public IActionResult GetPassengers()
        {
            return Ok(_passengerService.GetAll());
        }

        //[HttpPost("AddPassenger")]
        //public IActionResult AddPassenger(CreatePassengerRequestDTO request)
        //{
        //    return Ok(_passengerService.Add(request));
        //}

        [HttpPost("JoinTravel")]
        public IActionResult JoinToTravel(JoinTravelRequestDTO request)
        {
            return Ok(_passengerService.Add(request));
        }
    }
}
