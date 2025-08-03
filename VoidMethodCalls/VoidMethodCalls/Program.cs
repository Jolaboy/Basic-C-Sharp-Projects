using System;

namespace VoidMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Method Calling Section ---

            // Instantiating the VoidMethod. This creates an object of the class
            // so we can call its DoMathAndDisplay method.
            MyMathClass mathObject = new MyMathClass();

            // Calling the method, passing in two numbers in the default order.
            // num1 will be 12, and num2 will be 8.
            Console.WriteLine("Calling the method with standard arguments:");
            mathObject.DoMathAndDisplay(12, 8);
            Console.WriteLine(); // Added a blank line for readability.
            Console.ReadLine();

            // Calling the method again, this time specifying the parameters by name.
            // This is useful for improving code readability or when the order of
            // parameters is not clear. The order of the named parameters can be different
            // from the method's definition.
            Console.WriteLine("Calling the method with named arguments:");
            mathObject.DoMathAndDisplay(num2: 50, num1: 25);
            Console.WriteLine(); // Added a blank line for readability.
            Console.ReadLine();

            // Keeping the console window open until a key is pressed.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}


