using System;

namespace Calculator
{
    public static class OperationsFactory
    {
        public static ITwoArguments CreateOperation(string operation)
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

        public static IOneArgument CreateTrigonometriaOperation(string operation)
        {
            switch (operation)
            {
                case "Cos":
                    return new Cos();
                case "Ctg":
                    return new Ctg();
                case "Sqrt":
                    return new Sqrt();
                case "Tg":
                    return new Tg();
                case "Abs":
                    return new Abs();
                case "Sin":
                    return new Sin();
                default:
                    throw new Exception("Unknown operation!");
            }
        }
    }
}
