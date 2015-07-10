using System;

namespace Calculator.OneArg
{
    public class Tg : IOneArgument
    {
        /// <summary>
        /// Operation of tangens
        /// </summary>
        /// <param name="firstField">Argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField)
        {
            if (firstField == 90)
            {
                throw new Exception("Tan can't be equal 90");
            }
            else
            {
                return (Math.Tan(firstField));
            }
        }
    }
}
