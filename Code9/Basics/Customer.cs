namespace Basics
{
    /// <summary>
    /// Customer.
    /// </summary>
    public class Customer
    {
        private string _name;

        /// <summary>
        /// Gets or sets the first name.
        /// Property with the backing field. 
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// Auto=property.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets the full name.
        /// Expression body. 
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName  => $"{FirstName} {LastName}";
    }
}
