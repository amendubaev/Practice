using System;

namespace Calculator
{
    public class Abs : IOneArgument
    {
        /// <summary>
        /// Operation of modul
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField)
        {
            return (Math.Abs(firstField));
        }
    }
}
