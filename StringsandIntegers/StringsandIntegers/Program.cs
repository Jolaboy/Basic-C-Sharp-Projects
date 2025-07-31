using System;
using System.Collections.Generic;

namespace StringsandIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers to work with
            List<int> numbers = new List<int> { 100, 200, 300, 400, 500 };

            // Ask the user to enter a number to divide each element by
            Console.WriteLine("Enter a number to divide each number in the list by:");
            string userInput = Console.ReadLine(); // Read user input as a string

            try
            {
                // Convert the user input to an integer
                int divisor = Convert.ToInt32(userInput);

                // Loop through the list of numbers
                foreach (int number in numbers)
                {
                    // Divide each number by the user-provided divisor and display the result
                    Console.WriteLine($"{number} divided by {divisor} equals {number / divisor}");
                }
            }
            catch (FormatException ex)
            {
                // Catches non-numeric input (e.g., letters or symbols)
                Console.WriteLine("Error: Please enter a valid numeric value.");
                Console.WriteLine($"Technical details: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // Catches division by zero errors
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Technical details: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catches any other unexpected exceptions
                Console.WriteLine("An unexpected error occurred.");
                Console.WriteLine($"Technical details: {ex.Message}");
            }

            // Confirmation that code execution continues past the try/catch block
            Console.WriteLine("Program has exited the try/catch block and continued execution.");

        }
    }
}
