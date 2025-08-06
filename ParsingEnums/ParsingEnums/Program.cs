using System; // Required for Console input/output and Enum

namespace ParsingEnums
{
    // 1. Create an enum for the days of the week.
    // Enums (enumerations) provide a way to define a set of named integer constants.
    public enum DayOfWeek
    {
        Monday,    // By default, Monday = 0
        Tuesday,   // Tuesday = 1
        Wednesday, // Wednesday = 2
        Thursday,  // Thursday = 3
        Friday,    // Friday = 4
        Saturday,  // Saturday = 5
        Sunday     // Sunday = 6
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable of the DayOfWeek enum type.
            DayOfWeek currentDay;

            // 2. Prompt the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week (e.g., Monday, Tuesday):");
            string userInput = Console.ReadLine(); // Read the user's input as a string.

            // 3. Wrap the parsing statement in a try/catch block.
            try
            {
                // Assign the value to a variable of that enum data type.
                // Enum.Parse converts the string input to an enum value.
                // 'true' makes the parsing case-insensitive (e.g., "monday" works).
                currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userInput, true);

                // If parsing is successful, print the day to the console.
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException) // Catch specific exception for invalid enum parsing.
            {
                // 4. If an error occurs during parsing, print the specified message.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            catch (Exception ex) // Catch any other unexpected errors.
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }

            // Keep the console window open until a key is pressed.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

