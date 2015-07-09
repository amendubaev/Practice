using System;

namespace Calculator.OneArg
{
    public class Sin : IOneArgument
    {
        /// <summary>
        /// Operation of sinus
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <returns>
        /// Result of sin
        /// </returns>
        public double Calculate(double firstField)
        {
            return Math.Sin(firstField);
        }
    }
}
