using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            IGreetingService service = DoubleCheckedLockingGreetingService.Instance;
            IGreetingService service_2 = DoubleCheckedLockingGreetingService.Instance;

            service.Greet("DoubleCheckedLocking");
            service_2.Greet("DoubleCheckedLocking");
            
            IGreetingService service_3 = LazyObjectGreetingService.Instance;
            IGreetingService service_4 = LazyObjectGreetingService.Instance;

            service_3.Greet("LazyObject");
            service_4.Greet("LazyObject");
            
            IGreetingService service_5 = SimpleGreetingService.Instance;
            IGreetingService service_6 = SimpleGreetingService.Instance;

            service_5.Greet("Simple");
            service_6.Greet("Simple");
        }
    }
}
