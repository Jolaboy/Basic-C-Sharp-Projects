using System;

namespace ClassMethodOperations
{
    /// <summary>
    /// This is a static class, which means you do not need to create an object of it
    /// to call its methods. All members of a static class must also be static.
    /// </summary>
    public static class MyOperations
    {
        /// <summary>
        /// This is a void method that takes an integer and divides it by 2,
        /// then prints the result directly to the console.
        /// </summary>
        /// <param name="number">The integer to be divided.</param>
        public static void DivideByTwo(int number)
        {
            // Perform the division and store the integer result.
            int result = number / 2;
            Console.WriteLine($"The result of dividing {number} by 2 is: {result}");
        }

        /// <summary>
        /// This is an overloaded version of the DivideByTwo method. It takes a
        /// decimal number as a parameter and returns a decimal result.
        /// Overloading allows a method to have the same name but different
        /// parameter types.
        /// </summary>
        /// <param name="number">The decimal number to be divided.</param>
        /// <returns>The result of the division as a decimal.</returns>
        public static decimal DivideByTwo(decimal number)
        {
            // Perform the division and return the decimal result.
            return number / 2.0m;
        }

        /// <summary>
        /// This method takes two integers and uses an output parameter to return
        /// the remainder of the division. Methods with 'out' parameters are useful
        /// for returning multiple values from a single method call.
        /// </summary>
        /// <param name="dividend">The number to be divided.</param>
        /// <param name="divisor">The number to divide by.</param>
        /// <param name="remainder">An output parameter that will hold the remainder.</param>
        public static void GetRemainder(int dividend, int divisor, out int remainder)
        {
            // The method calculates the remainder using the modulus (%) operator.
            remainder = dividend % divisor;
        }
    }
}
