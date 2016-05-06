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
                var customer1 = new Customer() { FirstName = "Petar", LastName = "Petrovic" };
                customer1.Bicycles.Add(new Bicycle() { Manufacturer = "Trek", Year = 2016 });
                ctx.Customers.Add(customer1);

                var customer2 = new Customer() { FirstName = "Milan", LastName = "Milanovic" };
                customer2.Bicycles.Add(new Bicycle() { Manufacturer = "Giant", Year = 2015 });
                customer2.Bicycles.Add(new Bicycle() { Manufacturer = "Canondale", Year = 2016 });
                ctx.Customers.Add(customer2);

                ctx.SaveChanges();

                var customerBicycles = from c in ctx.Customers
                                       where c.FirstName == "Milan"
                                       select c.Bicycles;

                customerBicycles.SelectMany(item => item).ToList().ForEach(item => Console.WriteLine($"Manufacturer: {item.Manufacturer}"));

                var singleBikeCustomers = from c in ctx.Customers
                                          where c.Bicycles.Count == 1
                                          select c;

                ctx.Customers.RemoveRange(singleBikeCustomers);
                ctx.SaveChanges();
            }
        }
    }
}
