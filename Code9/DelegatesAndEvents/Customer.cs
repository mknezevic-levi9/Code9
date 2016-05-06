using System;

namespace DelegatesEventsAndLambdaExpressions
{
    /// <summary>
    /// Customer.
    /// </summary>
    public class Customer
    {
        public delegate bool CustomValidationDelegate(Customer customer);
        public delegate void ValidationCompletedDelegate(bool success);

        public event ValidationCompletedDelegate OnValidationCompleted;

        private CustomValidationDelegate _validationDelegate;

        public Customer(CustomValidationDelegate validationDelegate)
        {
            _validationDelegate = validationDelegate;
        }

        public string FirstName { get; set; } 

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

        public int Age { get; set; }

        /// <summary>
        /// Performs the custom validation.
        /// </summary>
        public void PerformCustomValidation()
        {
            if (_validationDelegate != null)
            {
                bool result = _validationDelegate(this);

                if (OnValidationCompleted != null)
                {
                    OnValidationCompleted(result);
                }
            }
        }
    }
}
