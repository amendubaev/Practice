using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtract : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return (firstField - secondField);
        }
    }
}
