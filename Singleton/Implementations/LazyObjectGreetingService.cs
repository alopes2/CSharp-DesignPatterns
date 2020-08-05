using System;

namespace Singleton
{
    public sealed class LazyObjectGreetingService : IGreetingService
    {
        private static readonly Lazy<LazyObjectGreetingService> _instance =
            new Lazy<LazyObjectGreetingService>(() => new LazyObjectGreetingService());

        // Random number is assigned to easily demonstrate that only one instance will be generated
        private readonly string _baseGreet = $"{new Random().Next(2, 100)} Greetings for";

        private LazyObjectGreetingService() { }

        public static IGreetingService Instance { get => _instance.Value; }

        public void Greet(string name)
        {
            Console.WriteLine($"{_baseGreet} {name}");
        }
    }
}