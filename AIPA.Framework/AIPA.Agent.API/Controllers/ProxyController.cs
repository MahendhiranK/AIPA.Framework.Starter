
using Microsoft.AspNetCore.Mvc;

namespace AIPA.Agent.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProxyController : ControllerBase
    {
        [HttpGet("enhance")]
        public IActionResult EnhanceRequest()
        {
            return Ok("AI Agent intercepted and enhanced this request.");
        }
    }
}
