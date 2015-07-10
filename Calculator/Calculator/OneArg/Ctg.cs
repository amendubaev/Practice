using System;

namespace Calculator
{
    public class Ctg : IOneArgument
    {
        /// <summary>
        /// Operation of cotangens
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
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
