using System;

namespace Attributes
{
    /// <summary>
    /// Defines maximum lengtha.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class MaxLengthAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Value { get; set; }
    }
}
