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

            ReWrittenQueries(customers);
        }

        protected static void ReWrittenQueries(List<Customer> customers)
        {

            // 1. where
            var resultLinq = customers.Where(c => c.Age == 35).Select(c => c);
            PrintResults("Basic linq query results:", resultLinq);

            // 2. lambda syntax
            var resultsExplicit = customers.Where(c => c.Age == 35).Select(c => c);
            PrintResults("Explicit query results:", resultsExplicit);

            // 3. ordering
            var orderedResult = customers.Where(c => c.Age < 35).OrderBy(c => c.Age).Select(c => c);
            PrintResults("Ordered results:", orderedResult);

            // 4. projecting with anonymous type
            var projectedResults = customers.Where(c => c.Age < 35).OrderBy(c => c.Age).Select(c =>
                                   new
                                   {
                                       Name = c.FullName,
                                       Age = c.Age
                                   });

            PrintResults("Projected results:", projectedResults);


            // 5. deferred execution
            var deferredResults = customers.Select(c => c);

            customers.Add(new Customer() { FirstName = "Bob", LastName = "Clarkson", Age = 40 });
            PrintResults("Should contain additional member (Bob Clarkson):", deferredResults);

            // 6. deferred execution materialized
            var deferredMaterialization = customers.Select(c => c);;

            var deferredResultMaterialized = deferredMaterialization.ToList();

            customers.Add(new Customer() { FirstName = "Martha", LastName = "King", Age = 40 });

            PrintResults("Should NOT contain additional member (Martha King):", deferredResultMaterialized);

            // 7. aggregation function (average)
            var averageAge = customers.Select(c => c).Average(c => c.Age);

            PrintResults($"Average age for customers below is {averageAge}", customers);

            // 8. aggregation function (max)
            var maximumAge = customers.Select(c => c).Max(c => c.Age);

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
