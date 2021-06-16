using DI_Playground.Abstractions;
using System;

namespace DI_Playground.Services
{
    public class ConsoleGreeter
    {
        private readonly IGreeting greeting;

        public ConsoleGreeter(IGreeting greeting)
        {
            this.greeting = greeting;
        }

        public void GreetConsole()
        {
            var greet = greeting.Greet();

            Console.WriteLine(greet);
        }
    }
}
