using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 1: Append User Text to Array Elements

            // Display program header
            Console.WriteLine("=== Text Appender to Array Elements ===\n");

            // Step 1: Create a one-dimensional array of strings
            string[] greetings = { "Hello", "Welcome", "Hi", "Greetings", "Hey" };

            // Step 2: Ask the user to input some text
            Console.Write("Enter a name or phrase to append to each greeting: ");
            string userInput = Console.ReadLine();

            // Step 3: Loop through the array and append the user's input to each element
            for (int i = 0; i < greetings.Length; i++)
            {
                // Append user's text to the current string
                greetings[i] += " " + userInput;
            }

            // Step 4: Loop again to display each updated string
            Console.WriteLine("\nUpdated greetings:");
            foreach (string message in greetings)
            {
                Console.WriteLine(message);
                Console.ReadLine();
            }
            
            // Part 2: Infinite Loop Demo
            Console.WriteLine("=== Array & List with User Input + Infinite Loop Demo ===\n");

            // Step 1: Define string array
            string[] messages = { "Hello", "Welcome", "Hi", "Hey", "Greetings" };

            // Step 2: Ask user for text to append
            Console.Write("Enter a phrase to add to each message: ");
            string messageInput = Console.ReadLine();

            // Step 3: First loop — update array values without displaying
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += " " + messageInput; // Append user input
            }

            // Step 4: Second loop — display updated array
            Console.WriteLine("\nUpdated messages:");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }

            // ========== Step 5: Infinite loop (initial version — broken) ==========
            /*
            while (true)
            {
                Console.WriteLine("This loop runs forever..."); // No exit condition
            }
            */

            // ========== Step 6: Fixed infinite loop ==========
            // We add an exit condition to stop the loop based on user input
            Console.WriteLine("\n--- Controlled Loop Example ---");
            string continueLoop = "y";

            // Loop will continue while user enters 'y'
            while (continueLoop.ToLower() == "y")
            {
                Console.Write("Type 'y' to loop again or any other key to exit: ");
                continueLoop = Console.ReadLine();
            }

            // End of program
            Console.WriteLine("\nLoop terminated. Program complete.");


            // Part 3: Loop Comparison Demo '<' & '<='
            Console.WriteLine("=== Loop Comparison Demo: '<' vs '<=' ===\n");

            // Loop using '<' operator — runs from 0 to 4
            Console.WriteLine("Loop using '<' operator (i < 5):");
            for (int i = 0; i < 5; i++) // ⬅️ Will run 5 times: i = 0 to 4
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine(); // Line break for clarity

            // Loop using '<=' operator — runs from 0 to 5
            Console.WriteLine("Loop using '<=' operator (j <= 5):");
            for (int j = 0; j <= 5; j++) // ⬅️ Will run 6 times: j = 0 to 5
            {
                Console.WriteLine($"j = {j}");
            }

            Console.WriteLine("\nExecution complete. You’ve seen both loop conditions in action.");

            // Part 4: Search List & Show Index
            Console.WriteLine("=== Unique List Search Demo ===\n");

            // Step 1: Define a unique list of strings
            List<string> techSkills = new List<string> { "React", "ASP.NET Core", "Docker", "Tailwind", "SQL Server" };

            // Step 2: Ask user for input text
            Console.Write("Enter a tech skill to search for: ");
            string skillSearched = Console.ReadLine();

            // Step 3: Boolean flag to track if match was found
            bool matchFound = false;

            // Step 4: Loop through the list and display the index if match is found
            for (int i = 0; i < techSkills.Count; i++)
            {
                if (techSkills[i].Equals(skillSearched, StringComparison.OrdinalIgnoreCase)) // Case-insensitive match
                {
                    Console.WriteLine($"\nMatch found at index {i}: {techSkills[i]}");
                    matchFound = true; // Set flag to true
                    break; // Stop loop early once match is found
                }
            }

            // Step 5: If no match is found, display message to user
            if (!matchFound)
            {
                Console.WriteLine("\nInput not found in the list. Please try again with a valid item.");
            }

            Console.WriteLine("\nProgram complete. Press any key to exit.");
            Console.ReadKey();

            // Track Duplicates Using foreach
            Console.WriteLine("=== Search for Multiple Matches Demo ===\n");

            // Step 1: Define a list with duplicate strings
            List<string> technologies = new List<string>
            {
                "React", "ASP.NET Core", "Docker", "React", "Tailwind", "Docker"
            };

            // Step 2: Ask user for input
            Console.Write("Enter a tech skill to search for: ");
            string skillEntered = Console.ReadLine();

            // Step 3: Track indices of matches
            List<int> matchingIndices = new List<int>();

            // Step 4: Loop through and store all matching indices
            for (int i = 0; i < technologies.Count; i++)
            {
                if (technologies[i].Equals(skillEntered, StringComparison.OrdinalIgnoreCase))
                {
                    matchingIndices.Add(i);
                }
            }

            // Step 5: Display result or error
            if (matchingIndices.Count > 0)
            {
                Console.WriteLine($"\n '{skillEntered}' found at the following index/indices:");
                foreach (int index in matchingIndices)
                {
                    Console.WriteLine($"- Index {index}");
                }
            }
            else
            {
                Console.WriteLine($"\n Sorry, '{skillEntered}' is not on the list.");
            }

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();



        }
    }
}
