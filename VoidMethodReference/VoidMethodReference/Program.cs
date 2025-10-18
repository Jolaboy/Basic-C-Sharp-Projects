using System;

// The 'void' keyword signifies that a method does not return a value.
// It is used exclusively in the method signature to specify the return type.

public class MethodExamples
{
    // --- 1. Classic Void Method Syntax ---
    // Multi-line implementation with explicit curly braces and statements.
    public void DisplayGreeting(string name)
    {
        // 'void' methods are used for executing actions or side effects,
        // such as printing to the console, saving a file, or modifying object state.
        Console.WriteLine($"\n--- Classic Method: DisplayGreeting ---");
        Console.WriteLine($"Hello, {name}. Welcome to the C# reference.");
        // The method ends here implicitly; no 'return' statement is needed.
    }

    // --- 2. Modern C# Syntax (Expression-Bodied Member) ---
    // If the method body consists of a single expression, C# allows this concise syntax.
    // This is equivalent to the classic syntax but much cleaner.
    public void PrintCurrentTime() =>
        Console.WriteLine($"\n--- Expression-Bodied Member: PrintCurrentTime --- \nCurrent time: {DateTime.Now:T}");

    // --- 3. Void Method with Parameters and Logic ---
    // This method takes two numbers, modifies the internal state of the program (the console output), 
    // but returns nothing.
    public void CalculateAndLogSum(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine($"\n--- Void Method with Logic: CalculateAndLogSum ---");
        Console.WriteLine($"The sum of {a} and {b} is: {sum}");
    }

    // --- 4. Using 'void' methods with Delegates (Action) ---
    // In modern C#, an 'Action' delegate represents a method that takes 0 to 16 arguments and returns 'void'.
    public void ExecuteAction(Action actionToRun)
    {
        Console.WriteLine($"\n--- Void and Delegates: ExecuteAction ---");
        Console.WriteLine("Starting the wrapped action...");
        actionToRun(); // Execute the 'void' method passed in.
        Console.WriteLine("Wrapped action finished.");
    }
}

public class Program
{
    public static void Main() // Main method is also 'void' as it doesn't return a value to the OS.
    {
        MethodExamples example = new MethodExamples();

        // Calling the classic void method
        example.DisplayGreeting("Amadou");

        // Calling the modern void method
        example.PrintCurrentTime();

        // Calling the void method with parameters
        example.CalculateAndLogSum(42, 108);

        // Calling the delegate executor with an anonymous 'void' method (a lambda expression)
        example.ExecuteAction(() =>
        {
            // This lambda expression is an anonymous 'void' method.
            Console.WriteLine("-> Running the inline Action (an anonymous void method).");
        });
    }
}

