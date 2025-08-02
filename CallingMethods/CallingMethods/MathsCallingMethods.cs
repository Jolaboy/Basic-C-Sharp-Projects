using System;

namespace CallingMethods
{
    internal class MathsCallingMethods
    {
        /// <summary>
        /// This method takes an integer, multiplies it by a fixed value,
        /// and returns the integer result.
        /// </summary>
        /// <param name="number">The integer value provided by the user.</param>
        /// <returns>The result of the multiplication.</returns>
        public int MultiplyByTwo(int number)
        {
            // The method multiplies the input number by 2 and returns the result.
            return number * 2;
        }

        /// <summary>
        /// This method takes an integer, adds a fixed value to it,
        /// and returns the integer result.
        /// </summary>
        /// <param name="number">The integer value provided by the user.</param>
        /// <returns>The result of the addition.</returns>
        public int AddFive(int number)
        {
            // The method adds 5 to the input number and returns the result.
            return number + 5;
        }

        /// <summary>
        /// This method takes an integer, subtracts a fixed value from it,
        /// and returns the integer result.
        /// </summary>
        /// <param name="number">The integer value provided by the user.</param>
        /// <returns>The result of the subtraction.</returns>
        public int SubtractTen(int number)
        {
            // The method subtracts 10 from the input number and returns the result.
            return number - 10;
        }
    }
}
