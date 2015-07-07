using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Abs : IOneArgument
    {
        public double Calculate(double firstField)
        {
            return (Math.Abs(firstField));
        }
    }
}
