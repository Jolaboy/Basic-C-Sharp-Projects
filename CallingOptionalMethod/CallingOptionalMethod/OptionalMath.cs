using System;

namespace MethodCalling
{
    /// <summary>
    /// This class contains a single method that demonstrates the use of an
    /// optional parameter to perform different mathematical operations.
    /// </summary>
    public class OptionalMath
    {
        /// <summary>
        /// This method takes two integers as parameters. The second parameter is optional
        /// and has a default value of 1.
        /// If only one number is provided, the method multiplies it by 10.
        /// If two numbers are provided, the method adds them together.
        /// </summary>
        /// <param name="number1">The first integer parameter.</param>
        /// <param name="number2">The second integer parameter, which is optional.</param>
        /// <returns>An integer result of either addition or multiplication.</returns>
        public int PerformOperation(int number1, int number2 = 1)
        {
            // The method checks if the optional parameter was passed with its default value.
            if (number2 == 1)
            {
                // If number2 is its default value, it means only one number was provided by the user.
                // We perform a multiplication in this case.
                return number1 * 10;
            }
            else
            {
                // If a second number was provided, we perform an addition.
                return number1 + number2;
            }
        }
    }
}

