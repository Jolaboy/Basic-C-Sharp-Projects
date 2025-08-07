using System; // Required for Console input/output
using System.Collections.Generic;  // Required for using the List<T> class
using System.Linq; // Required for using LINQ methods like Where() and ToList()

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Employee List Creation ---
            // Create a list of Employee objects. We are initializing the list
            // with 12 employees, with two of them having the first name "Joe".
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Gomez" },
                new Employee { Id = 2, FirstName = "John", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Peter", LastName = "Taylor" },
                new Employee { Id = 5, FirstName = "Mary", LastName = "Williams" },
                new Employee { Id = 6, FirstName = "Amadou", LastName = "Jarju" },
                new Employee { Id = 7, FirstName = "Mariama", LastName = "Bojang" }, 
                new Employee { Id = 8, FirstName = "Sarah", LastName = "Miller" },
                new Employee { Id = 9, FirstName = "Mark", LastName = "Wilson" },
                new Employee { Id = 10, FirstName = "Emily", LastName = "Taylor" },
                new Employee { Id = 11, FirstName = "Chris", LastName = "Anderson" },
                new Employee { Id = 12, FirstName = "Joe", LastName = "Silva" } // A third "Joe" for good measure
            };

            // --- Filtering with a foreach loop ---
            // Create a new list to store the employees with the first name "Joe".
            List<Employee> joesWithForeach = new List<Employee>();

            // Use a foreach loop to iterate through the entire list of employees.
            foreach (Employee employee in employees)
            {
                // Check if the current employee's FirstName property is "Joe".
                if (employee.FirstName == "Joe")
                {
                    // If the condition is true, add the employee to our new list.
                    joesWithForeach.Add(employee);
                }
            }

            // Print the results of the foreach loop.
            Console.WriteLine("Employees with the first name 'Joe' (using a foreach loop):");
            foreach (Employee joe in joesWithForeach)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine(); // This adds a blank line for readability.

            // --- Filtering with a lambda expression ---
            // Perform the same action as the foreach loop, but with a lambda expression.
            // The Where() method from LINQ returns a new sequence of elements that satisfy
            // the condition provided by the lambda expression.
            // The ToList() method converts the result back into a list.
            List<Employee> joesWithLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Print the results of the lambda expression.
            Console.WriteLine("Employees with the first name 'Joe' (using a lambda expression):");
            foreach (Employee joe in joesWithLambda)
            {
                Console.WriteLine($"ID: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }
            Console.WriteLine(); // This adds a blank line for readability.

            // --- Filtering with a lambda expression for IDs ---
            // Use a lambda expression to create a new list of all employees
            // with an Id number greater than 5.
            List<Employee> highIdEmployees = employees.Where(employee => employee.Id > 5).ToList();

            // Print the results of the lambda expression for the IDs.
            Console.WriteLine("Employees with an ID greater than 5 (filtred using a lambda):");
            foreach (Employee employee in highIdEmployees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            // This keeps the console window open until a key is pressed.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
