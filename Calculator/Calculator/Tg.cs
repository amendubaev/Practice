using System;

namespace Calculator
{
    public class Tg : IOneArgument
    {
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
