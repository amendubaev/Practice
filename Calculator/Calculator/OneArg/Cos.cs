using System;

namespace Calculator.OneArg
{
    public class Cos : IOneArgument
    {
        /// <summary>
        /// Operation of cosinus
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <returns>
        /// Result of cos
        /// </returns>
        public double Calculate(double firstField)
        {
            return (Math.Cos(firstField));
        }
    }
}
