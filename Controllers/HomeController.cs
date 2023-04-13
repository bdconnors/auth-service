using Microsoft.AspNetCore.Mvc;

namespace Auth.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {


        [HttpGet]
        public string Get()
        {
            return "Hello World";
        }
    }
}