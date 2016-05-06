using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        public static void Main()
        {
            Task runTask = Run();
            runTask.Wait();
        }

        static async Task Run()
        {
            Console.WriteLine("Please choose example:");
            Console.WriteLine("1. Blocking");
            Console.WriteLine("2. Non-blocking");
            Console.Write("> ");
            var inputKey = Console.ReadKey().KeyChar;

            if (inputKey == '1')
            {
                var blockingExample = new BlockingExample();
                blockingExample.Run();
            }
            else if (inputKey == '2')
            {
                var nonBlockingExample = new NonBlockingExample();
                await nonBlockingExample.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice, please restart application");
            }
        }
    }
}
