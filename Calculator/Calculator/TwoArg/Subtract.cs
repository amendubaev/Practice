
namespace Calculator
{
    public class Subtract : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return (firstField - secondField);
        }
    }
}
