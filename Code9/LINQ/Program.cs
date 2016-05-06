using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialization
            var customers = new List<Customer>()
            {
                new Customer() { FirstName = "Rada", LastName = "Radanovic", Age = 20 },
                new Customer() { FirstName = "Petar", LastName = "Petrovic", Age = 25 },
                new Customer() { FirstName = "Branka", LastName = "Brankovic", Age = 30 },
                new Customer() { FirstName = "Milan", LastName = "Milanovic", Age = 35 },
                new Customer() { FirstName = "Jane", LastName = "Doe", Age = 20 },
                new Customer() { FirstName = "John", LastName = "Smith", Age = 35 }
            };

            // 1. where
            var resultLinq = from c in customers
                             where c.Age == 35
                             select c;

            PrintResults("Basic linq query results:", resultLinq);

            // 2. lambda syntax
            var resultsExplicit = customers.Where(c => c.Age == 35).Select(c => c);
            PrintResults("Explicit query results:", resultsExplicit);

            // 3. ordering
            var orderedResult = from c in customers
                                where c.Age < 35
                                orderby c.Age
                                select c;

            PrintResults("Ordered results:", orderedResult);

            // 4. projecting with anonymous type
            var projectedResults = from c in customers
                                   where c.Age < 35
                                   orderby c.Age
                                   select new
                                   {
                                       Name = c.FullName,
                                       Age = c.Age
                                   };

            PrintResults("Projected results:", projectedResults);


            // 5. deferred execution
            var deferredResults = from c in customers
                                  select c;

            customers.Add(new Customer() { FirstName = "Bob", LastName = "Clarkson", Age = 40 });
            PrintResults("Should contain additional member (Bob Clarkson):", deferredResults);

            // 6. deferred execution materialized
            var deferredMaterialization = from c in customers
                                          select c;

            var deferredResultMaterialized = deferredMaterialization.ToList();

            customers.Add(new Customer() { FirstName = "Martha", LastName = "King", Age = 40 });

            PrintResults("Should NOT contain additional member (Martha King):", deferredResultMaterialized);


            // 7. aggregation function (average)
            var averageAge = (from c in customers
                              select c).Average(c => c.Age);

            PrintResults($"Average age for customers below is {averageAge}", customers);


            // 8. aggregation function (max)
            var maximumAge = (from c in customers
                              select c).Max(c => c.Age);

            PrintResults($"Maximum age of customers below is {maximumAge}", customers);
        }

        protected static void PrintResults<T>(string label, IEnumerable<T> results)
        {
            Console.WriteLine(label);
            results.ToList().ForEach(element => Console.WriteLine(element));
            Console.WriteLine();
        }
    }
}
