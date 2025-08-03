using System;

namespace ClassMethodOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- User Input Section ---
            Console.WriteLine("Please enter a whole number to be divided by 2:");
            string input = Console.ReadLine();

            int userNumber;

            // Let's use a while loop with int.TryParse to ensure the user provides valid input.
            while (!int.TryParse(input, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.WriteLine("Enter a number:");
                input = Console.ReadLine();
            }

            // --- Method Calling Section ---
            // The class is static, so we don't need to create an object of it.
            // We can call the static method directly using the class name.
            Console.WriteLine("\n--- Calling the DivideByTwo method with an integer ---");
            MyOperations.DivideByTwo(userNumber);

            // Calling the overloaded version of the method with a decimal.
            Console.WriteLine("\n--- Calling the overloaded DivideByTwo method with a decimal ---");
            decimal decimalResult = MyOperations.DivideByTwo(123.45m);
            Console.WriteLine($"The result of dividing 123.45 by 2 is: {decimalResult}");

            // --- Calling the method with an 'out' parameter ---
            Console.WriteLine("\n--- Calling the method with an output parameter ---");
            int remainderResult; // Declared a variable to receive the output parameter.
            MyOperations.GetRemainder(userNumber, 2, out remainderResult);
            Console.WriteLine($"The remainder of {userNumber} divided by 2 is: {remainderResult}");

            // --- To keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
