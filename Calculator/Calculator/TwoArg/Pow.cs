using System;

namespace Calculator.TwoArg
{
    public class Pow : ITwoArguments
    {
        /// <summary>
        /// Oeration of exponent by using Math.Pow
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <param name="secondField">
        /// Input exponent on the second field
        /// </param>
        /// <returns>
        /// Result firstfield^secondfield
        /// </returns>
        public double Calculate(double firstField, double secondField)
        {
            return Math.Pow(firstField, secondField);
        }
    }
}
