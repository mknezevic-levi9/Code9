using System;

namespace Attributes
{
    /// <summary>
    /// Attribute for range validation
    /// </summary>
    /// <seealso cref="System.Attribute" />
    public class RangeCheckAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the minimum value.
        /// </summary>
        /// <value>
        /// The minimum value.
        /// </value>
        public int MinimumValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum value.
        /// </summary>
        /// <value>
        /// The maximum value.
        /// </value>
        public int MaximumValue { get; set; }
    }
}
