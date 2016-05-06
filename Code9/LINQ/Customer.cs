namespace LINQ
{
    /// <summary>
    /// Customer.
    /// </summary>
    public class Customer
    {
        public string FirstName { get; set; } 

        public string LastName { get; set; }

        public string FullName  => $"{FirstName} {LastName}";

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FullName}: {Age}";
        }
    }
}
