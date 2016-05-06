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
            var webscrapper = new WebScrapper();

            var webScrapperTask = webscrapper.GetPageContentAsync(@"http://www.yahoo.com");

            // doing some work until page is downloaded
            Console.WriteLine("Interface is not blocked while page is downloaded in background");
            Console.WriteLine("...");

            Console.WriteLine("Now we are waiting for downloader to finish");
            var result = await webScrapperTask;

            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"DONE. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
