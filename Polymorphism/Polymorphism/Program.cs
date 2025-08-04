using System;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Instantiation and Polymorphism ---
            // Create a new Employee object. The employee has a first and last name.
            Employee employee = new Employee
            {
                FirstName = "Amadou",
                LastName = "Jarju"
            };

            // This is an example of polymorphism. We're creating a variable of type
            // IQuittable (the interface) and assigning our Employee object to it.
            // This works because the Employee class implements the IQuittable interface.
            IQuittable quittableEmployee = employee;

            // --- Method Calls ---
            // Call the SayName() method on the Employee object.
            Console.WriteLine("Calling the SayName() method:");
            employee.SayName();

            // Call the Quit() method using the IQuittable object.
            // The compiler knows to use the Quit() method implemented in the
            // Employee class because that's the underlying object type.
            Console.WriteLine("\nCalling the Quit() method via the IQuittable interface:");
            quittableEmployee.Quit();

            // --- Keep the console window open ---
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
