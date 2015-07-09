
using System;

namespace Calculator.TwoArg
{
    public class Divide : ITwoArguments
    {
        /// <summary>
        /// Operation of division and added exception if secondField = 0.
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <param name="secondField">
        /// Input one argument on the second field
        /// </param>
        /// <returns>
        /// Result firstField/secondField
        /// </returns>
        public double Calculate(double firstField, double secondField)
        {
            if (secondField == 0)
            {
                throw new Exception("Division by 0!");
            }
            else
            {
                if (firstField == 0)
                {
                    return 0;
                }
                else
                {
                    return (firstField/secondField);
                }
            }
        }
    }
}
