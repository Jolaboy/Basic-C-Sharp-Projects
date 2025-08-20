using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- User Input Section ---
            // Prompt the user to enter a number.
            Console.Write("Please enter a number: ");

            // Read the user's input from the console as a string.
            string userInput = Console.ReadLine();

            // --- File Writing Section ---
            // Define the path for the text file. The file will be created in the same directory
            // as the executable, inside a folder named 'bin/Debug'.
            string filePath = "log.txt";

            // Use a try-catch block to handle potential errors during file operations,
            // such as a lack of write permissions.
            try
            {
                // Write the user's input to the text file.
                // The using statement ensures the StreamWriter object is properly disposed of
                // and the file is closed automatically, even if an error occurs.
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(userInput);
                }

                // Confirm to the user that the number has been logged.
                Console.WriteLine($"\nSuccessfully logged the number '{userInput}' to {filePath}.");
            }
            catch (Exception ex)
            {
                // If any error occurs during the file write process, display an error message.
                Console.WriteLine($"\nAn error occurred while writing to the file: {ex.Message}");
                // We'll stop the program here if the write operation fails.
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                return; // Exit the Main method.
            }

            // --- File Reading Section ---
            // Now, read the content back from the text file.
            Console.WriteLine("\nReading the content of the text file back to the console:");

            // Another try-catch block for the reading operation.
            try
            {
                // Use the using statement again to ensure the StreamReader is disposed.
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the entire content of the file into a string.
                    string fileContent = reader.ReadToEnd();

                    // Print the content of the file to the console.
                    Console.WriteLine(fileContent);
                }
            }
            catch (Exception ex)
            {
                // If an error occurs during the file read process, display an error message.
                Console.WriteLine($"\nAn error occurred while reading the file: {ex.Message}");
            }

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
