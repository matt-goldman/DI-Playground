using DI_Playground.Abstractions;

namespace DI_Playground.Services
{
    public class HelloService : IGreeting
    {
        public string Greet()
        {
            return "Hello World";
        }
    }
}
