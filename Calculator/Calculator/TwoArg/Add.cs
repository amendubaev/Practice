namespace Calculator.TwoArg
{
    public class Add : ITwoArguments
    {
        /// <summary>
        /// Operation of addition
        /// </summary>
        /// <param name="firstField">
        /// Input one argument on the first field
        /// </param>
        /// <param name="secondField">
        /// Input one argument on the second field
        /// </param>
        /// <returns>
        /// Result - firstfield + secondfield
        /// </returns>
        public double Calculate(double firstField, double secondField)
        {
            return (firstField + secondField);
        }
    }
}
