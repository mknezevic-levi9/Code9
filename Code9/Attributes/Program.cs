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
                LastName = "PetrovicPetrovicPetrovicPetrovicPetrovicPetrovicPetrovicPetrovic",
                Age = 2
            };

            ValidateCustomer(customer);
        }

        private static void ValidateCustomer(Customer customer)
        {
            var customerType = customer.GetType();
            var customerProperties = customerType.GetProperties();
            foreach (var property in customerProperties)
            {
                foreach (var attribute in property.GetCustomAttributes(false))
                {
                    if (attribute is MaxLengthAttribute && property.PropertyType == typeof(string))
                    {
                        // check string length
                        var length = ((string)property.GetValue(customer)).Length;
                        if (length > ((MaxLengthAttribute)attribute).Value)
                        {
                            Console.WriteLine($"Validation failed. Property {property.Name} has invalid length of {length}");
                        }
                    }
                    else if (attribute is RangeCheckAttribute && property.PropertyType == typeof(int))
                    {
                        // check string length
                        var attrValue = (int)property.GetValue(customer);
                        if (attrValue < ((RangeCheckAttribute)attribute).MinimumValue ||
                            attrValue > ((RangeCheckAttribute)attribute).MaximumValue)
                        {
                            Console.WriteLine($"Validation failed. Property {property.Name} has invalid range of {attrValue}");
                        }
                    }
                }
            }
        }
    }
}
