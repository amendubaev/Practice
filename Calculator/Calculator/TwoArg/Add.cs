namespace Calculator.TwoArg
{
    public class Add : ITwoArguments
    {
        /// <summary>
        /// Operation of addition
        /// </summary>
        /// <param name="firstField">First argument</param>
        /// <param name="secondField">Second argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField, double secondField)
        {
            return (firstField + secondField);
        }
    }
}
