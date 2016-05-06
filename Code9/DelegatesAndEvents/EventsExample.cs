using System;

namespace DelegatesEventsAndLambdaExpressions
{
    /// <summary>
    /// Events example
    /// </summary>
    public class EventsExample
    {
        /// <summary>
        /// Definition of delegate type for <see cref="OnCalculationCompleted"/> event.
        /// </summary>
        /// <param name="result"></param>
        public delegate void CalculationCompletedDelegate(int result);

        /// <summary>
        /// Raised when calculation is completed.
        /// </summary>
        public event CalculationCompletedDelegate OnCalculationCompleted;

        public void Run()
        {
            // do some processing
            int result = 15;

            if (OnCalculationCompleted != null)
            {
                OnCalculationCompleted(result);
            }
        }
    }
}