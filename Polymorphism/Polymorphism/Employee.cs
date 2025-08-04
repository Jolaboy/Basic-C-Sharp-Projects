using System;

namespace Polymorphism
{
    /// <summary>
    /// The Employee class inherits from the abstract Person class and also
    /// implements the IQuittable interface.
    /// </summary>
    public class Employee : Person, IQuittable
    {
        /// <summary>
        /// This method is an implementation of the abstract SayName() method from the
        /// Person class. It overrides the base method to provide specific functionality.
        /// </summary>
        public override void SayName()
        {
            // Use string interpolation to display the full name.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }

        /// <summary>
        /// This method is the implementation of the Quit() method from the IQuittable
        /// interface. It simply prints a message to the console.
        /// </summary>
        public void Quit()
        {
            Console.WriteLine("The employee is quitting the job.");
        }
    }

}
