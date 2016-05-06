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
            // instantiate customer and pass custom validation method
            var customer = new Customer(PerformCustomValidation)
            {
                FirstName = "Petar",
                LastName = "Petrovic",
                Age = 20
            };

            // subscribe to validation completed event
            customer.OnValidationCompleted += ValidationCompletedHandler;

            // invoke method which should initiate validation flow
            customer.PerformCustomValidation(); // should output result to console
        }

        protected static bool PerformCustomValidation(Customer customer)
        {
            int maxLength = 20;
            int minAge = 14;
            int maxAge = 100;

            if (customer == null)
            {
                return false;
            }

            if (customer.FirstName == null || customer.FirstName.Length > maxLength)
            {
                return false;
            }

            if (customer.LastName == null || customer.LastName.Length > maxLength)
            {
                return false;
            }


            if (customer.Age < minAge || customer.Age > maxAge) 
            {
                return false;
            }

            return true;
        }

        private static void ValidationCompletedHandler(bool success)
        {
            Console.WriteLine($"Validation result: {success}");
        }
    }
}
