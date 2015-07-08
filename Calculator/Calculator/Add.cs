namespace Calculator
{
    public class Add : ITwoArguments
    {
        public double Calculate(double firstField, double secondField)
        {
            return (firstField + secondField);
        }
    }
}
