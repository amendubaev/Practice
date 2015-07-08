
namespace Calculator
{
    public class Multiply : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return (firstField * secondField);
        }
    }
}
