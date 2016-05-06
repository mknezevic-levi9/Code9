using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelExtensions
{
    class Program
    {
        private const int ParallelTasksCount = 500;
        private const int OperationsNumMin = 1000000;
        private const int OperationsNumsMax = 10000000;

        private static Random random = new Random();

        static void Main(string[] args)
        {
            var operationsCountPerTask = Initialize();

            // sequential
            Stopwatch sequentialSw = new Stopwatch();
            sequentialSw.Start();

            foreach (var operationsCount in operationsCountPerTask)
            {
                Process(operationsCount);
            }

            sequentialSw.Stop();
            Console.WriteLine($"Sequential execution {sequentialSw.ElapsedMilliseconds}[ms]");


            // parallel
            Stopwatch parallelSw = new Stopwatch();
            parallelSw.Start();

            Parallel.ForEach(operationsCountPerTask, t => Process(t));

            parallelSw.Stop();
            Console.WriteLine($"Parallel execution {parallelSw.ElapsedMilliseconds}[ms]");


            Console.ReadKey();
        }

        static int[] Initialize()
        {
            int[] retVal = new int[ParallelTasksCount];
            for (int i = 0; i < ParallelTasksCount; i++)
            {
                retVal[i] = random.Next(OperationsNumMin, OperationsNumsMax);
            }

            return retVal;
        }

        static void Process(int size)
        {
            int num = 0;
            for (int i = 0; i < size; i++)
            {
                num++;
            }
        }
    }
}
