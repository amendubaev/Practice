
namespace Calculator.TwoArg
{
    public class Multiply : ITwoArguments
    {
        /// <summary>
        /// Operation of multiplication
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <param name="secondField">
        /// Input one argument on the second field
        /// </param>
        /// <returns>
        /// Result firstfield * secondfield
        /// </returns>
        public double Calculate(double firstField, double secondField)
        {
            return (firstField * secondField);
        }
    }
}
