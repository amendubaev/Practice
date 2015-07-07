using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class OperationsFactory
    {
        public static IOperation CreateOperation(string operation)
        {
            switch (operation)
            {
                case "Multiply": return new Multiply();
                case "Subtract": return new Subtract();
                case "Divide": return new Divide();
                case "Add": return new Add();
                case "Pow": return new Pow();
                default: throw new Exception("Unknown operation!");
            }
        }

        public static ITrigonometria CreateTrigonometriaOperation(string operation)
        {
            switch (operation)
            {
                case "Sin": return new Sin();
                default: throw new Exception("Unknown operation!");
            }
        }
    }
}
