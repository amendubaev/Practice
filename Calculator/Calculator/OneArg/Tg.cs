using System;

namespace Calculator.OneArg
{
    public class Tg : IOneArgument
    {
        /// <summary>
        /// Operation of tangens and added exception if firstfield = 90
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <returns>
        /// Result of tan
        /// </returns>
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
