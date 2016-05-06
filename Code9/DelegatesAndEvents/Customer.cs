using System;

namespace DelegatesEventsAndLambdaExpressions
{
    /// <summary>
    /// Customer.
    /// </summary>
    public class Customer
    {
        // TODO: define validation delegate
        // TODO: define event delegate

        // TODO: pass validation delegate via constructor
        // TODO: add validation finished event

        public Customer(/*TODO: add validation delegate*/)
        {
        }

        public string FirstName { get; set; } 

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

        public int Age { get; set; }

        public void PerformCustomValidation()
        {
            // TODO: invoke custom validation delegate
            // TODO: raise event

            throw new NotImplementedException();
        }
    }
}
