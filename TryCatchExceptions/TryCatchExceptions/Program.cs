using System; // Required for using the DateTime class and Console operations

namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- User Input and Validation ---
            try
            {
                // 1. Ask the user for their age.
                Console.Write("Please enter your current age: ");

                // Read the user's input as a string.
                string userInput = Console.ReadLine();

                // Convert the user's input to an integer. This is the part that could
                // throw an exception if the input is not a valid number.
                int userAge = Convert.ToInt32(userInput);

                // Check for invalid age (zero or negative numbers).
                if (userAge <= 0)
                {
                    // If the age is invalid, throw a custom exception with a specific message.
                    // This allows us to handle this specific error case in the catch block.
                    throw new ArgumentException("Age must be a positive number.");
                }

                // --- Calculate and Display Birth Year ---
                // Get the current year from the system's date and time.
                int currentYear = DateTime.Now.Year;

                // Calculate the birth year by subtracting the age from the current year.
                int birthYear = currentYear - userAge;

                // Display the calculated birth year to the console.
                Console.WriteLine($"\nBased on your age, you were likely born in the year {birthYear}.");
            }
            // --- Exception Handling ---
            catch (ArgumentException ex)
            {
                // This catch block handles the custom exception we threw for invalid age.
                // It prints the specific error message we provided.
                Console.WriteLine("\nError: " + ex.Message);
            }
            catch (FormatException)
            {
                // This catch block handles the FormatException that occurs when
                // the user enters something that is not a number.
                Console.WriteLine("\nError: Please enter a valid number for your age.");
            }
            catch (Exception)
            {
                // This is a general catch block that will handle any other unexpected exceptions.
                // It's a good practice to include a general catch-all for robustness.
                Console.WriteLine("\nAn unexpected error occurred. Please try again.");
            }

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
