using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<int, string>()
            {
                { 1, "first element" },
                { 2, "seconds element" }
            };

            var failResult = dictionary.AddIfNotExists(1, "another attempt for first element");
            Console.WriteLine($"Attempt to add same key resulted in {failResult} result");
            PrintDictionary(dictionary);

            Console.WriteLine();

            var successResult = dictionary.AddIfNotExists(3, "attempt to add new key");
            Console.WriteLine($"Attempt to add same key resulted in {successResult} result");
            PrintDictionary(dictionary);
        }

        static void PrintDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary)
        {
            dictionary.ToList().ForEach(kvPair => Console.WriteLine($"{kvPair.Key}:{kvPair.Value}"));
        }
    }
}
