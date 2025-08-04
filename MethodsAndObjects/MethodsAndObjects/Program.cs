using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Instantiation and Initialization ---
            // Instantiate an Employee object. The 'new Employee()' creates a new instance.
            // We can then initialize its properties using the object initializer syntax.
            // Notice that we can set FirstName and LastName, which are inherited from the Person class.
            Employee employee = new Employee()
            {
                FirstName = "Sample", // Set the FirstName property.
                LastName = "Student" // Set the LastName property.
            };

            // --- Method Call ---
            // Call the superclass SayName() method on the employee object.
            // This method was inherited from the base Person class.
            Console.WriteLine("Calling the SayName() method on the Employee object:");
            employee.SayName();

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
