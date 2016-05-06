using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    /// <summary>
    /// Extensions for <see cref="System.Collections.Generic.List{T}"/>.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Determines whether [is null or empty].
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        public static bool IsNullOrEmpty<TSource>(this List<TSource> input)
        {
            return input == null || input.Count == 0;
        }

        public static void PrintToConsole<TSource>(this List<TSource> input)
        {
            if (!input.IsNullOrEmpty())
            {
                input.ForEach(e => Console.WriteLine(e));
            }
        }
    }
}
