
namespace Calculator
{
    public class Divide : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return (firstField / secondField);
        }
    }
}
