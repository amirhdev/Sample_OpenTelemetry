using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        var people = new List<string>() { "Johnny Depp", "Tom Cruise" };
        return Ok(people);
    }
}