using CERAXLAN.Adesso.Business.Abstract;
using CERAXLAN.Adesso.Entities.Concrete;
using CERAXLAN.Adesso.Entities.Request;
using CERAXLAN.Adesso.Entities.Request.Travel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CERAXLAN.Adesso.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelsController : ControllerBase
    {
        private readonly ITravelService _travelService;

        public TravelsController(ITravelService travelService)
        {
            _travelService = travelService;
        }

        [HttpPost("FindTravel")]
        public IActionResult FindTravel(FindTravelRequestDTO request)
        {
            return Ok(_travelService.FindTravel(request));
        }

        [HttpGet("GetTravels")]
        public IActionResult GetTravels()
        {
            return Ok(_travelService.GetAll());
        }

        [HttpPost("GetTravelWithPassengers")]
        public IActionResult GetTravelWithPassengers(int id)
        {
            return Ok(_travelService.GetByIdWithPassengers(id));
        }

    }
}
