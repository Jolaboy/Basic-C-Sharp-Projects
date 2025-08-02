using System;

namespace MainMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- This is the Method Calling Section ---
            /* Let's instantiate the MathOperations class. This creates an object
             that we can use to call the methods defined in that class.*/
            MathOperations mathOps = new MathOperations();

            // --- Calling the first method with an integer ---
            int intNumber = 20; // An integer value to pass to the first method.
            int result1 = mathOps.PerformOperation(intNumber); // Calling the method.
            Console.WriteLine($"Result of the operation with integer {intNumber}: {result1}");

            // --- Calling the second method with a decimal ---
            decimal decimalNumber = 35.5m; // A decimal value to pass to the second method.
            int result2 = mathOps.PerformOperation(decimalNumber); // Calling the method.
            Console.WriteLine($"Result of the operation with decimal {decimalNumber}: {result2}");

            // --- Calling the third method with a string ---
            string stringNumber = "100"; // A string value that can be converted to an integer.
            int result3 = mathOps.PerformOperation(stringNumber); // Calling the method.
            Console.WriteLine($"Result of the operation with string \"{stringNumber}\": {result3}");
            Console.ReadLine();

            // --- This will keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
