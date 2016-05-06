using System;
using System.Collections.Generic;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Customer and initialize it
            var customer = new Customer()
            {
                FirstName = "Petar",
                LastName = "Petrovic"
            };

            Console.WriteLine($"First name: {customer.FirstName}");
            Console.WriteLine($"Last name: {customer.LastName}");
            Console.WriteLine($"Full name: {customer.FullName}");

            // create and initialize list of customers
            var customers = new List<Customer>()
            {
                customer,
                new Customer()
                {
                    FirstName = "Petar",
                    LastName = "Petrovic"
                }
            };


            // assignment solution
            var assignmentCustomer = new Customer()
            {
                FirstName = "Assignment",
                LastName = "Customer",
                Bicycles = new List<Bicycle>()
                {
                    new Bicycle() { Manufacturer = "Trek", BicycleType = "Road", Year = 2015 },
                    new Bicycle() { Manufacturer = "Cannondale", BicycleType = "MTB", Year = 2015 }
                }
            };
        }
    }
}
