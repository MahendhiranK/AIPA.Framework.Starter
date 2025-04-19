
using Microsoft.AspNetCore.Mvc;

namespace AIPA.Sample.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok("This is the Sample API responding with data.");
        }
    }
}
