using System;

namespace Calculator.OneArg
{
    public class Cos : IOneArgument
    {
        /// <summary>
        /// Operation of cosinus
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField)
        {
            return (Math.Cos(firstField));
        }
    }
}
