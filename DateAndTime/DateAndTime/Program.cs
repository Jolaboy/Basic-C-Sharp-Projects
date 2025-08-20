using System; // Required for using the DateTime and TimeSpan data types, and for Console operations

namespace DateTimeImplementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Step 1: Get and print the current date and time ---
            // Get the current date and time from the system.
            DateTime currentTime = DateTime.Now;

            // Print the current date and time to the console.
            Console.WriteLine("The current date and time is:");
            Console.WriteLine(currentTime);
            Console.WriteLine(); // Add a blank line for readability.

            // --- Step 2: Ask the user for a number of hours ---
            // Prompt the user to enter a number of hours.
            Console.Write("Please enter a whole number of hours: ");

            // Read the user's input as a string.
            string userInput = Console.ReadLine();

            // Declare an integer variable to store the parsed number of hours.
            int hoursToAdd;

            // Use a while loop with int.TryParse to ensure the input is a valid integer.
            while (!int.TryParse(userInput, out hoursToAdd))
            {
                // If parsing fails, inform the user and re-prompt for a valid number.
                Console.WriteLine("Invalid input. Please enter a valid whole number.");
                Console.Write("Enter a number of hours: ");
                userInput = Console.ReadLine();
            }

            // --- Step 3: Calculate and print the future date and time ---
            // The AddHours() method is used to add the specified number of hours
            // to the current DateTime object.
            DateTime futureTime = currentTime.AddHours(hoursToAdd);

            // Print the future date and time to the console.
            Console.WriteLine(); // Add a blank line.
            Console.WriteLine($"In exactly {hoursToAdd} hours, the date and time will be:");
            Console.WriteLine(futureTime);

            // --- Keep the console window open ---
            // This line prevents the console window from closing immediately
            // after the program finishes executing.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

