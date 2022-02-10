using Microsoft.AspNetCore.Mvc;

namespace EnsekInterviewExercise.Controllers
{
    [ApiController]
    public class SubmitMeterReadingsController : ControllerBase
    {
        public SubmitMeterReadingsController()
        {
        }

 
        [HttpPost]
        [Route("meter-readings-uploads")]
        public IActionResult SubmitMeterReading(IFormFile data)
        {
            return Ok();
        }

    }
}