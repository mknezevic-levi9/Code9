using System;
namespace DelegatesEventsAndLambdaExpressions
{
    /// <summary>
    /// Delegates example.
    /// </summary>
    public class DelegatesExample
    {
        public delegate int CalculateDelegate(int x, int y);

        public void Run()
        {
            CalculateDelegate calcDelegate;

            // method
            calcDelegate = new CalculateDelegate(Add);

            // anonymous method 
            //calcDelegate = delegate (int x, int y)
            //{
            //    return x * y;
            //};

            // lambda 
            //calcDelegate = (x, y) => x - y;

            // output
            var result = calcDelegate(5, 6);
            Console.WriteLine($"Calculation result: {result}");
        }

        protected int Add(int x, int y)
        {
            return x + y;
        }
    }
}
