using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new BikeShopContext())
            {
                var customers = new List<Customer>()
                {
                    new Customer() { FirstName = "Petar", LastName = "Petrovic" },
                    new Customer() { FirstName = "Milan", LastName = "Milanovic" }
                };

                ctx.Customers.AddRange(customers);
                ctx.SaveChanges();

                var filteredCustomers = from c in ctx.Customers
                                       where c.FirstName == "Milan"
                                       select c;

                filteredCustomers.ToList().ForEach(item => Console.WriteLine($"First name: {item.FirstName}"));

                var exCustomer = filteredCustomers.FirstOrDefault();
                ctx.Customers.Remove(exCustomer);
                ctx.SaveChanges();
            }
        }
    }
}
