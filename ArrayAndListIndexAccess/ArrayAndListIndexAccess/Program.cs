using System;
using System.Collections.Generic;

namespace ArrayAndListIndexAccess
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Array and List Index Access Demo ===\n");

            // ========== STRING ARRAY ==========
            // Create a one-dimensional array of strings
            string[] names = { "Amadou", "Jenna", "Raj", "Layla", "Noah", "Mariama", "Fatou", "Aisha" };

            // Prompt user to select an index
            Console.Write("Select an index (0–7) to view a name: ");
            string input1 = Console.ReadLine();

            // Try to parse and access array safely
            if (int.TryParse(input1, out int index1) && index1 >= 0 && index1 < names.Length)
            {
                Console.WriteLine($"Name at index {index1}: {names[index1]}");
            }
            else
            {
                Console.WriteLine("Invalid index — no such name found.\n");
            }

            // ========== INTEGER ARRAY ==========
            // Create a one-dimensional array of integers
            int[] scores = { 88, 92, 76, 95, 83, 79, 100, 110 };

            // Prompt user to select an index
            Console.Write("\nSelect an index (0–7) to view a score: ");
            string input2 = Console.ReadLine();

            // Validate index before accessing
            if (int.TryParse(input2, out int index2) && index2 >= 0 && index2 < scores.Length)
            {
                Console.WriteLine($"Score at index {index2}: {scores[index2]}");
            }
            else
            {
                Console.WriteLine("Invalid index — score not found.\n");
            }

            // ========== STRING LIST ==========
            // Create a List of strings
            List<string> techStack = new List<string> { "React", "ASP.NET Core", "Tailwind", "Docker", "SQL Server", "Azure", "MangoDB", "Bootstrap"};

            // Prompt user to select an index
            Console.Write("\nSelect an index (0–7) to view a tech stack item: ");
            string input3 = Console.ReadLine();

            // Safely access list with index validation
            if (int.TryParse(input3, out int index3) && index3 >= 0 && index3 < techStack.Count)
            {
                Console.WriteLine($"Tech stack item at index {index3}: {techStack[index3]}");
            }
            else
            {
                Console.WriteLine("Invalid index — no such item in tech stack.\n");
            }

            // End of program
            Console.WriteLine("\nThanks for exploring array and list indexing!");

        }
    }
}
