using System; // Required for using the Console class

namespace ConstructorChaining
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Step 1: Create a const variable ---
            // 'const' is a keyword that makes a variable a constant. This means
            // its value must be assigned at compile time and cannot be changed later.
            const string schoolName = "Ams Tech Academy";

            // Print the constant variable to the console.
            Console.WriteLine($"The school's name is a constant called: {schoolName}");
            Console.WriteLine(); // Add a blank line for readability.

            // --- Step 2: Create a variable using the keyword “var” ---
            // 'var' is a keyword that allows the compiler to infer the data type
            // from the value assigned to the variable. Here, 'greeting' will be a string.
            var greeting = "Hello Amadou!";

            // Print the variable declared with 'var' to the console.
            Console.WriteLine($"This greeting is declared with 'var': {greeting}");
            Console.WriteLine();

            // --- Step 3: Chain two constructors together ---
            // Here, we are creating an object using the constructor that takes only one parameter.
            // The constructor will then automatically "chain" and call the second constructor,
            // which handles the initialization of both the 'Message' and 'Number' properties.
            ChainedConstructors myObject = new ChainedConstructors("This is a message from the chained constructor.");

            // Print the properties to show that both were initialized.
            Console.WriteLine("Object created using the chained constructor:");
            Console.WriteLine($"Message: {myObject.Message}");
            Console.WriteLine($"Number: {myObject.Number}");

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

