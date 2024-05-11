using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/{controller}")]
public class CongregantsController : ControllerBase
{
    public CongregantsController() { }

    [HttpGet]
    [Route("/")]
    public IActionResult Get()
    {
        return Ok("Wired up a controller");
    }
}