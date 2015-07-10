
namespace Calculator.TwoArg
{
    public class Subtract : ITwoArguments
    {
        /// <summary>
        /// Operation of subtraction
        /// </summary>
        /// <param name="firstField">First argument</param>
        /// <param name="secondField">Second argument</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField, double secondField)
        {
            return (firstField - secondField);
        }
    }
}
