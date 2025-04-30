using Microsoft.AspNetCore.Mvc;
using AIPA.ApiDiscovery.Models;
using AIPA.ApiDiscovery.Services;

namespace AIPA.ApiDiscovery.Controllers;

[ApiController]
[Route("api/discovery")]
public class ApiRegistryController : ControllerBase
{
    private static readonly ApiRegistryService _service = new();

    [HttpPost("register")]
    public IActionResult RegisterApi([FromBody] ApiDescriptor descriptor)
    {
        _service.Register(descriptor);
        return Ok("API registered successfully.");
    }

    [HttpGet("all")]
    public IActionResult GetAllApis()
    {
        return Ok(_service.GetAll());
    }

    [HttpGet("{name}")]
    public IActionResult GetApiByName(string name)
    {
        var api = _service.GetByName(name);
        if (api == null)
            return NotFound("API not found.");
        return Ok(api);
    }
}
