using System;

namespace Calculator
{
    public class Sqrt : IOneArgument
    {
        public double Calculate(double firstField)
        {
            if (firstField <= 0)
            {
                throw new Exception("the number under the sqrt can't be negative or equal 0");
            }
            else
            {
                return (Math.Sqrt(firstField));
            }
        }
    }
}
