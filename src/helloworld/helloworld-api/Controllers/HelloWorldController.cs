using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloworld_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet("SayHello")]
        public string SayHello()
        {
            return "Hello World!";
        }
    }
}