using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEventsAndLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // delegates
            var delegates = new DelegatesExample();
            delegates.Run();

            // events
            var events = new EventsExample();

            // subscribe to event
            events.OnCalculationCompleted += CalculationCompletedHandler;

            // execute operation which should result in raising event
            events.Run();
        }

        protected static void CalculationCompletedHandler(int result)
        {
            Console.WriteLine($"Calculation completed with result: {result}");
        }
    }
}
