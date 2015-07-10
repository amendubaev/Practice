
namespace Calculator.TwoArg
{
    public class Multiply : ITwoArguments
    {
        /// <summary>
        /// Operation of multiplication
        /// </summary>
        /// <param name="firstField">First argument</param>
        /// <param name="secondField">Second argumrent</param>
        /// <returns>Result</returns>
        public double Calculate(double firstField, double secondField)
        {
            return (firstField * secondField);
        }
    }
}
