using System;


namespace MethodCalling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- User Input Section ---
            // Instantiate the OptionalMath class to access its methods.
            OptionalMath math = new OptionalMath();

            // Prompt the user for the first number.
            Console.WriteLine("Enter a whole number:");
            string input1 = Console.ReadLine();
            int number1;

            // Use a while loop with int.TryParse to ensure the input is a valid integer.
            while (!int.TryParse(input1, out number1))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.WriteLine("Enter a whole number:");
                input1 = Console.ReadLine();
            }

            // Prompt the user for the second number, noting it's optional.
            Console.WriteLine("Enter a second whole number (optional):");
            string input2 = Console.ReadLine();

            // --- Method Calling Section ---
            // This demonstrates calling the method with only one number.
            Console.WriteLine("\nCalling method with only the first number:");
            int resultSingle = math.PerformOperation(number1);
            Console.WriteLine($"Result: {number1} * 10 = {resultSingle}");

            // This block checks if the user provided a second number.
            if (!string.IsNullOrWhiteSpace(input2))
            {
                // If the second input is not empty, try to parse it.
                if (int.TryParse(input2, out int number2))
                {
                    // If parsing is successful, call the method with both numbers.
                    Console.WriteLine("\nCalling method with both numbers:");
                    int resultDouble = math.PerformOperation(number1, number2);
                    Console.WriteLine($"Result: {number1} + {number2} = {resultDouble}");
                }
                else
                {
                    // If the second input is invalid, inform the user but still show the single number result.
                    Console.WriteLine("\nInvalid second number input. Showing result with only the first number.");
                }
            }
            else
            {
                // If the second input was left blank, inform the user.
                Console.WriteLine("\nSecond number was not provided. Showing result with only the first number.");
            }

            // Keep the console window open until a key is pressed.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
