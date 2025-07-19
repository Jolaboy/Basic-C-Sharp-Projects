using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print title for clarity
            Console.WriteLine("Boolean Comparison Demo with While and Do-While Statements");
            Console.WriteLine("----------------------------------------------------------");

            // ========== Boolean Comparison Using WHILE ==========
            // We will use a counter to track iterations
            int counter = 0;

            // Loop runs as long as counter is less than 3
            while (counter < 3)
            {
                Console.WriteLine($"While Loop Iteration: {counter}");
                counter++; // Increment the counter each time
            }
            // After counter reaches 3, condition becomes false and loop stops


            // ========== Boolean Comparison Using DO-WHILE ==========
            // Reset counter for new loop demonstration
            counter = 5;

            // Do-while ensures the loop runs at least once, even if condition is false
            do
            {
                Console.WriteLine($"Do-While Loop Iteration: {counter}");
                counter++; // Increment counter
            }
            while (counter < 5); // This is false from the start, but loop still runs once

        }


    }
}
