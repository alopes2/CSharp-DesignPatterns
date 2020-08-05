using System;

namespace Singleton
{
    public sealed class SimpleGreetingService : IGreetingService
    {
        // Random number is assigned to easily demonstrate that only one instance will be generated
        private readonly string _baseGreet = $"{new Random().Next(2, 100)} Greetings for";

        static SimpleGreetingService() { }

        private SimpleGreetingService() { }

        // .NET can leverage auto-properties to assign the singleton instance when it first run
        public static IGreetingService Instance { get; } = new SimpleGreetingService();

        public void Greet(string name)
        {
            Console.WriteLine($"{_baseGreet} {name}");
        }
    }
}