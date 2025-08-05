using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Instantiating Employee Objects ---
            // Create two Employee objects with the same Id.
            Employee employee1 = new Employee { Id = 0101, FirstName = "Amadou", LastName = "Jarju" };
            Employee employee2 = new Employee { Id = 0101, FirstName = "Amie", LastName = "Sanneh" };

            // Create a third Employee object with a different Id.
            Employee employee3 = new Employee { Id = 0102, FirstName = "Assan", LastName = "Njie" };

            // --- Testing the Overloaded == Operator ---
            Console.WriteLine("--- Testing the '==' operator ---");

            // Compare employee1 and employee2 (same Id).
            if (employee1 == employee2)
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee2.FirstName} are considered equal.");
            }
            else
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee2.FirstName} are NOT considered equal.");
            }

            // Compare employee1 and employee3 (different Id).
            if (employee1 == employee3)
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee3.FirstName} are considered equal.");
            }
            else
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee3.FirstName} are NOT considered equal.");
            }

            // --- Testing the Overloaded != Operator ---
            Console.WriteLine("\n--- Testing the '!=' operator ---");

            // Compare employee1 and employee2 (same Id).
            if (employee1 != employee2)
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee2.FirstName} are NOT considered equal.");
            }
            else
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee2.FirstName} are considered equal.");
            }

            // Compare employee1 and employee3 (different Id).
            if (employee1 != employee3)
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee3.FirstName} are NOT considered equal.");
            }
            else
            {
                Console.WriteLine($"Result: {employee1.FirstName} and {employee3.FirstName} are considered equal.");
            }

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
