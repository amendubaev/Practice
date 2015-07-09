using System;

namespace Calculator.OneArg
{
    public class Abs : IOneArgument
    {
        /// <summary>
        /// Operation of module
        /// </summary>
        /// <param name="firstField">
        /// Input one Argument
        /// </param>
        /// <returns>
        /// Result of abs
        /// </returns>
        public double Calculate(double firstField)
        {
            return (Math.Abs(firstField));
        }
    }
}
