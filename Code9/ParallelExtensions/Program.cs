using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelExtensions
{
    class Program
    {
        static void Main(string[] args)
        {
            // sequential
            Stopwatch sw = new Stopwatch();
            sw.Start();

            FileSystemTraverse.ProcessDirectory(@"C:\Users\user\.nuget");

            sw.Stop();
            Console.WriteLine($"FileSystemTraverse execution: {sw.ElapsedMilliseconds}[ms]");

            Console.ReadKey();
        }
    }
}
