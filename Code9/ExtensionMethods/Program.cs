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
            var intList = new List<int>()
            {
                0, 1, 2, 3, 4
            };

            intList.PrintToConsole();
        }
    }
}
