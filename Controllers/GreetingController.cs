using Microsoft.AspNetCore.Mvc;
using DI_Playground.Abstractions;
using DI_Playground.CustomResolver;

namespace DI_Playground.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var svc = Resolver.Resolve<IGreeting>();

            return svc.Greet();
        }
    }
}
