using System;

namespace Calculator.OneArg
{
    public class Sqrt : IOneArgument
    {
        /// <summary>
        /// Operation of radical and added exception, if firstfield = 0
        /// </summary>
        /// <param name="firstField">
        /// Argument
        /// </param>
        /// <returns>
        /// Result
        /// </returns>
        public double Calculate(double firstField)
        {
            if (firstField <= 0)
            {
                throw new Exception("the number under the sqrt can't be negative or equal 0");
            }
            else
            {
                return (Math.Sqrt(firstField));
            }
        }
    }
}
