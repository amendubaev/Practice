using System;

namespace Calculator
{
    public class Ctg : IOneArgument
    {
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
