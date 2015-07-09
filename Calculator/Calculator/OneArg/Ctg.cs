using System;

namespace Calculator.OneArg
{
    public class Ctg : IOneArgument
    {
        /// <summary>
        /// Operation of cotangens and added exception if first field = 0
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <returns>
        /// Result of ctg(1/tan)
        /// </returns>
        public double Calculate(double firstField)
        {
            if (firstField == 0)
            {
                throw new Exception("Ctg can't be equal 0");
            }
            else
            {
                return ((1/Math.Tan(firstField)));
            }
        }
    }
}
