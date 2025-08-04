using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Instantiation and Initialization ---
            // Instantiate an Employee object. Even though the Employee class inherits from
            // an abstract class, it is a concrete class and can be instantiated.
            // We can then initialize its inherited properties.
            Employee employee = new Employee()
            {
                FirstName = "Sample",   // Inherited property from Person.
                LastName = "Student"    // Inherited property from Person.
            };

            // --- Method Call ---
            // Call the SayName() method on the employee object.
            // This method is the concrete implementation provided in the Employee class.
            Console.WriteLine("Calling the SayName() method on the Employee object:");
            employee.SayName();

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
