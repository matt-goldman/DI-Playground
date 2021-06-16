using Microsoft.AspNetCore.Mvc;
using DI_Playground.Abstractions;
using DI_Playground.CustomResolver;
using DI_Playground.Services;

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

            var consolegreet = Resolver.Resolve<ConsoleGreeter>();

            consolegreet.GreetConsole();

            return svc.Greet();
        }
    }
}
