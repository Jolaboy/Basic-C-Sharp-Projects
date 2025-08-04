using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    /// <summary>
    /// The Employee class inherits from the abstract Person class.
    /// Because it inherits from an abstract class, it is required to
    /// provide an implementation for the abstract SayName() method.
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// This method overrides the abstract SayName() method from the base
        /// Person class and provides a concrete implementation.
        /// </summary>
        public override void SayName()
        {
            // Use string interpolation to format and display the full name
            // using the inherited FirstName and LastName properties.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
