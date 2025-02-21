using Microsoft.AspNetCore.Mvc;

namespace RESTful_API.Example.Controllers.v1;

[ApiController]
public class ExampleController : Controller
{
    [HttpGet("test")]
    public async Task<ActionResult> Test()
    {
        return Ok();
    }
}
