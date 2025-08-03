using System;

namespace VoidMethod
{
    /// <summary>
    /// This class contains a method that performs a math operation
    /// and displays a second number to the console.
    /// </summary>
    public class MyMathClass
    {
        /// <summary>
        /// This is a void method, which means it does not return a value.
        /// It takes two integers as parameters.
        /// </summary>
        /// <param name="num1">The first integer to perform an operation on.</param>
        /// <param name="num2">The second integer to display on the screen.</param>
        public void DoMathAndDisplay(int num1, int num2)
        {
            // Perform a math operation on the first integer.
            // For this example, we will multiply it by 5.
            int result = num1 * 5;

            // The method's primary task is to perform an operation, but it
            // also prints the second number to the console.
            Console.WriteLine("The second number is: " + num2);
            Console.WriteLine($"The result of the math operation on the first number is: {result}");
        }
    }
}

