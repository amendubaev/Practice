
using System;
using System.Diagnostics.Eventing.Reader;

namespace Calculator
{
    public class Divide : ITwoArguments
    {
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
