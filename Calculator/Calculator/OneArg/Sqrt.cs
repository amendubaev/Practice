using System;

namespace Calculator
{
    public class Sqrt : IOneArgument
    {
        /// <summary>
        /// Operation of radical
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
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
