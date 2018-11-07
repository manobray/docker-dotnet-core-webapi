using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TestDocker.Business;
using TestDocker.Models;

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
            return new AuthorsBusiness().First();
        }
    }
}
