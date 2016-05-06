using System;
using System.Threading.Tasks;

namespace Async
{
    public class NonBlockingExample
    {
        public async Task Run()
        {
            Task<int> longRunningTask = null;
            char inputKey;

            do
            {
                PrintMenu();

                inputKey = Console.ReadKey().KeyChar;

                switch (inputKey)
                {
                    case '1':
                        // long running operation 
                        longRunningTask = SimulateLongRunningOperation();
                        break;

                    case '2':
                        PrintHelp();
                        break;

                    default:
                        break;
                }

            } while (inputKey.ToString().ToUpper() != "Q");


            if (longRunningTask != null)
            {
                Console.WriteLine();
                Console.WriteLine("Waiting for long running operation to finish");
                var result = await longRunningTask;
                Console.WriteLine($"Result of long-running operation {result}");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
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
            Console.WriteLine("Non-blocking example");
            Console.WriteLine($"Please choose:");
            Console.WriteLine();
            Console.WriteLine($"1) Start long-running operation");
            Console.WriteLine($"2) Display help");
            Console.WriteLine($"q) quit");
            Console.Write($"> ");
        }

        private async Task<int> SimulateLongRunningOperation()
        {
            Console.WriteLine();
            Console.WriteLine("Long-running operation started");
            // do nothing for 30 seconds
            await Task.Delay(30000);
            Console.WriteLine("Long-running operation finished");

            return 30000;
        }
    }
}
