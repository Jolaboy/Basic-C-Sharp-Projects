using System; // Required for Console input/output operations
using System.Collections.Generic; // Not strictly needed for this simple example, but often useful
using System.Linq; // Not strictly needed for this simple example, but often useful
using System.Text; // Not strictly needed for this simple example, but often useful
using System.Threading.Tasks; // Not strictly needed for this simple example, but often useful

namespace MathOperations // Defines a namespace to organise related code
{
    internal class Program // Defines a class named Program, which is the entry point for the application
    {
        static void Main(string[] args) // The Main method, where the program execution begins
        {
            // Declare and initialize two integer variables for calculations
            int a = 50;
            int b = 30;

            // --- Addition ---
            // Perform addition
            int sum = a + b;
            // Print the result of addition using string interpolation
            Console.WriteLine($"The sum of {a} and {b} is: {sum}");

            // --- Subtraction ---
            // Perform subtraction
            int difference = a - b;
            // Print the result of subtraction
            Console.WriteLine($"The difference between {a} and {b} is: {difference}");

            // --- Multiplication ---
            // Perform multiplication
            int product = a * b;
            // Print the result of multiplication
            Console.WriteLine($"The product of {a} and {b} is: {product}");

            // --- Division ---
            // Perform integer division (result will be an integer, discarding remainder)
            // To get a floating-point result, cast one of the operands to a float or double: (float)a / b
            int quotient = a / b;
            // Print the result of division
            Console.WriteLine($"The quotient of {a} divided by {b} is: {quotient}");

            // --- Modulus (Remainder) ---
            // Perform modulus operation to get the remainder of a division
            int remainder = a % b;
            // Print the result of the modulus operation
            Console.WriteLine($"The remainder of {a} divided by {b} is: {remainder}");

            // Keep the console window open until a key is pressed (useful for console applications)
            Console.ReadKey();
        }
    }
}

