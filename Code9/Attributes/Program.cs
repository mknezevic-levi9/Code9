using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                FirstName = "Petar",
                LastName = "PetrovicPetrovicPetrovicPetrovicPetrovicPetrovicPetrovicPetrovic"
            };

            // extract attribute from type
            var customerType = customer.GetType();
            var customerProperties = customerType.GetProperties();
            foreach (var property in customerProperties)
            {
                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    if (attribute is MaxLengthAttribute && property.PropertyType == typeof(string))
                    {
                        // check string length
                        if (((string)property.GetValue(customer)).Length > ((MaxLengthAttribute)attribute).Value)
                        {
                            Console.WriteLine($"Validation failed. Property {property.Name} has invalid length");
                        }
                    }
                }
            }
        }
    }
}
