using System;
using System.Collections.Generic;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Iterating through an array of test scores
            int[] testScores = { 100, 75, 67, 95, 87, 80, 90, 85, 92, 88, 55 };

            for (int i = 0; i < testScores.Length; i++)

                if (testScores[i] > 80)
                {
                    Console.WriteLine("High score: " + testScores[i]);
                }
            Console.ReadLine();

            // Iterating an array of strings
            string[] names = { "Alice", "Terry", "Kim", "James", "Bob", "Sally" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Kim")
                {
                    Console.WriteLine(names[j]); // Prints name
                    Console.WriteLine("Found Kim at index: " + j);  // Prints index  
                }
            }
            Console.ReadLine();

            // Iterating through lists
            List<int> testScoresList = new List<int> { 98, 99, 85, 72, 79 };

            foreach (int score in testScoresList)
            {
                if (score > 80)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }
            Console.ReadLine();

            // List string
            List<string> studentNames = new List<string> { "Amadou", "Fatou", "Buba", "Mariama", "Lamin" };
            foreach (string name in studentNames)
            {
                if (name == "Buba")
                {
                    Console.WriteLine(name); // Prints name
                }
            }
            Console.ReadLine();

            // Lets print the whole list of student names
            foreach (string name in studentNames)
            {
                Console.WriteLine(name); // Prints each name in the list   
            }
            Console.ReadLine();

            // Check the number of passing scores
            List<int> testScores1 = new List<int>() { 87, 75, 85, 90, 98 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores1)
            {
                if (score > 80)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
