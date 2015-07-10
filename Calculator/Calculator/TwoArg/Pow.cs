using System;

namespace Calculator.TwoArg
{
    public class Pow : ITwoArguments
    {
        /// <summary>
        /// Oeration of exponent
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <param name="secondField">Exponent</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField, double secondField)
        {
            return Math.Pow(firstField, secondField);
        }
    }
}
