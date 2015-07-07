using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Ctg : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return ((1/Math.Tan(firstField)));
        }
    }
}
