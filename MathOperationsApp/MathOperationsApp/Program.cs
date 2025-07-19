using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Operation 1: Multiply by 50 ---
            Console.WriteLine("--- Operation 1: Multiply by 50 ---");
            Console.Write("Enter a number to multiply by 50: "); // Prompt the user for input
            string input1 = Console.ReadLine(); // Read the user's input as a string

            // Declare a long variable to store the parsed input, allowing for large numbers
            long number1;
            // Use a while loop and TryParse to ensure valid numerical input
            while (!long.TryParse(input1, out number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number."); // Error message for invalid input
                Console.Write("Enter a number to multiply by 50: "); // Re-prompt
                input1 = Console.ReadLine(); // Re-read input
            }

            long result1 = number1 * 50; // Perform the multiplication
            Console.WriteLine($"Result: {number1} * 50 = {result1}"); // Print the result using string interpolation
            Console.WriteLine(); // Print an empty line for better readability


            // --- Operation 2: Add 25 ---
            Console.WriteLine("--- Operation 2: Add 25 ---");
            Console.Write("Enter a number to add 25 to: "); // Prompt the user for input
            string input2 = Console.ReadLine(); // Read the user's input as a string

            // Declare a long variable for the second number
            long number2;
            // Use a while loop and TryParse to ensure valid numerical input
            while (!long.TryParse(input2, out number2))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number."); // Error message
                Console.Write("Enter a number to add 25 to: "); // Re-prompt
                input2 = Console.ReadLine(); // Re-read input
            }

            long result2 = number2 + 25; // Perform the addition
            Console.WriteLine($"Result: {number2} + 25 = {result2}"); // Print the result
            Console.WriteLine(); // Print an empty line


            // --- Operation 3: Divide by 12.5 ---
            Console.WriteLine("--- Operation 3: Divide by 12.5 ---");
            Console.Write("Enter a number to divide by 12.5: "); // Prompt the user for input
            string input3 = Console.ReadLine(); // Read the user's input as a string

            // Declare a double variable to store the parsed input, as division involves decimals
            double number3;
            // Use a while loop and TryParse to ensure valid numerical input (can be decimal)
            while (!double.TryParse(input3, out number3))
            {
                Console.WriteLine("Invalid input. Please enter a valid number (e.g., 10.5, 200)."); // Error message
                Console.Write("Enter a number to divide by 12.5: "); // Re-prompt
                input3 = Console.ReadLine(); // Re-read input
            }

            double divisor = 12.5; // Define the divisor as a double
            double result3 = number3 / divisor; // Perform the division
            Console.WriteLine($"Result: {number3} / {divisor} = {result3}"); // Print the result
            Console.WriteLine(); // Print an empty line


            // --- Operation 4: Check if greater than 50 ---
            Console.WriteLine("--- Operation 4: Check if greater than 50 ---");
            Console.Write("Enter a number to check if it's greater than 50: "); // Prompt the user for input
            string input4 = Console.ReadLine(); // Read the user's input as a string

            // Declare a double variable, as the input could be a decimal
            double number4;
            // Use a while loop and TryParse to ensure valid numerical input
            while (!double.TryParse(input4, out number4))
            {
                Console.WriteLine("Invalid input. Please enter a valid number."); // Error message
                Console.Write("Enter a number to check if it's greater than 50: "); // Re-prompt
                input4 = Console.ReadLine(); // Re-read input
            }

            bool isGreaterThan50 = number4 > 50; // Perform the comparison
            Console.WriteLine($"Is {number4} greater than 50? {isGreaterThan50}"); // Print the boolean result
            Console.WriteLine(); // Print an empty line


            // --- Operation 5: Get remainder when divided by 7 ---
            Console.WriteLine("--- Operation 5: Get remainder when divided by 7 ---");
            Console.Write("Enter a number to find its remainder when divided by 7: "); // Prompt the user for input
            string input5 = Console.ReadLine(); // Read the user's input as a string

            // Declare a long variable for the fifth number (remainder usually applies to integers)
            long number5;
            // Use a while loop and TryParse to ensure valid whole number input
            while (!long.TryParse(input5, out number5))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number."); // Error message
                Console.Write("Enter a number to find its remainder when divided by 7: "); // Re-prompt
                input5 = Console.ReadLine(); // Re-read input
            }

            long result5 = number5 % 7; // Perform the modulus operation
            Console.WriteLine($"The remainder of {number5} divided by 7 is: {result5}"); // Print the remainder
            Console.WriteLine(); // Print an empty line


            // Keep the console window open until a key is pressed
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
