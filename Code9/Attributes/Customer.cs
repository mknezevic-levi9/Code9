

namespace Attributes
{
    /// <summary>
    /// Customer.
    /// </summary>
    public class Customer
    {
        [MaxLength(Value = 20)]
        public string FirstName { get; set; } 

        [MaxLength(Value = 20)]
        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

        [RangeCheck(MinimumValue = 14, MaximumValue = 100)]
        public int Age { get; set; }
    }
}
