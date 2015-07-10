using System;

namespace Calculator.OneArg
{
    public class Sin : IOneArgument
    {
        /// <summary>
        /// Operation of sinus
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField)
        {
            return Math.Sin(firstField);
        }
    }
}
