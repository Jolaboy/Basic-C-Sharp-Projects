using System; // Required for Console input/output

namespace StructImplementation
{
    /// <summary>
    /// Creates a struct named Number.
    /// Structs are value types in C#, typically used for small data structures
    /// that primarily store data. They are stored directly where they are declared.
    /// </summary>
    public struct Number
    {
        // Property named "Amount" of data type decimal.
        // The 'decimal' data type is used for financial calculations or
        // whenever high precision and accuracy are required, as it avoids
        // the floating-point inaccuracies that can occur with 'float' or 'double'.
        public decimal Amount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Struct Assignment ---
            // 1. Create an object (an instance) of the Number struct.
            // When you create a struct, memory is allocated directly on the stack
            // (or inline within another object), and its fields are initialized to their default values.
            Number myNumber = new Number();

            // 2. Assign a decimal value to the "Amount" property of the myNumber object.
            // The 'm' suffix (e.g., 123.45m) is crucial for decimal literals in C#.
            // Without 'm', the number would be treated as a double, requiring a cast.
            myNumber.Amount = 123.45m;

            // 3. Print the assigned amount to the console.
            // This demonstrates that the value has been successfully stored and can be accessed.
            Console.WriteLine($"The amount from the Number struct is: {myNumber.Amount}");

            // Keep the console window open until a key is pressed.
            // This line is important for console applications so they don't
            // close immediately after execution, allowing the user to see the output.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
