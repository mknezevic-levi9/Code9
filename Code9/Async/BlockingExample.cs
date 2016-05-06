using System;
using System.Threading;

namespace Async
{
    public class BlockingExample
    {
        public void Run()
        {
            char inputKey;

            do
            {
                PrintMenu();

                inputKey = Console.ReadKey().KeyChar;

                switch (inputKey)
                {
                    case '1':
                        var result = SimulateLongRunningOperation();
                        Console.WriteLine($"Result of long-running operation {result}");
                        break;

                    case '2':
                        PrintHelp();
                        break;

                    default:
                        break;
                }

            } while (inputKey.ToString().ToUpper() != "Q");
        }

        private void PrintHelp()
        {
            Console.WriteLine();
            Console.WriteLine($"In order to enable interface responsiveness we must not block main thread of application. ");
            Console.WriteLine($"There are couple of ways to achieve this, and async/await mechanism is one of them. ");
            Console.WriteLine();
        }

        private void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Blocking example:");
            Console.WriteLine($"Please choose:");
            Console.WriteLine();
            Console.WriteLine($"1) Start long-running operation");
            Console.WriteLine($"2) Display help");
            Console.WriteLine($"q) quit");
            Console.Write($"> ");
        }

        private static int SimulateLongRunningOperation()
        {
            Console.WriteLine();
            Console.WriteLine("Long-running operation started");
            // do nothing for 5 seconds
            Thread.Sleep(5000);
            Console.WriteLine("Long-running operation finished");
            Console.WriteLine();

            return 5000;
        }
    }
}
