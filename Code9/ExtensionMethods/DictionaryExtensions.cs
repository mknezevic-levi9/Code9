using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    /// <summary>
    /// Extensions for <see cref="Dictionary{TKey, TValue}"/>
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Adds element to dictionary if it does not exists.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="input">The input.</param>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Input dictionary cannot be null</exception>
        public static bool AddIfNotExists<TKey, TValue>(this Dictionary<TKey, TValue> input, TKey key, TValue value)
        {
            if (input == null)
            {
                throw new ArgumentException("Input dictionary cannot be null", nameof(input));
            }

            if (input.ContainsKey(key))
            {
                return false;
            }

            input.Add(key, value);
            return true;
        }
    }
}
