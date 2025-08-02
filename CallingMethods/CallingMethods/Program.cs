
using System;

namespace CallingMethods
{
    internal class MathsCallingMathods
    {
        static void Main(string[] args)
        {
            // --- User Input Section ---
            Console.WriteLine("Please enter a whole number to perform some math operations on:");
            string input = Console.ReadLine();
            int userNumber;
            while (!int.TryParse(input, out userNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.WriteLine("Please enter a number:");
                input = Console.ReadLine();
            }

            // --- Method Calling Section ---
            MathsCallingMethods mathOps = new MathsCallingMethods();
            int result1 = mathOps.MultiplyByTwo(userNumber);
            int result2 = mathOps.AddFive(userNumber);
            int result3 = mathOps.SubtractTen(userNumber);

            // --- Output Section ---
            Console.WriteLine($"\nPerforming operations on the number: {userNumber}");
            Console.WriteLine($"Result of multiplication: {result1}");
            Console.WriteLine($"Result of addition: {result2}");
            Console.WriteLine($"Result of subtraction: {result3}");
            Console.ReadLine();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}