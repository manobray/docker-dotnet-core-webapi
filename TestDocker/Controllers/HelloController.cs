using Microsoft.AspNetCore.Mvc;

namespace TestDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET: api/Hello
        [HttpGet]
        public string Get()
        {
            return "Hello from .NET Core";
        }
    }
}
