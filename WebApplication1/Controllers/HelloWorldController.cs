using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("/api")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public ActionResult HelloWorld ()
    {
        return Ok("Hello World!");
    }
}