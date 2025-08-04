using System;

namespace MethodsAndObjects
{
    /// <summary>
    /// This is the base class representing a person. It has properties
    /// for a person's first and last name.
    /// </summary>
    public class Person
    {
        // A public string property to store the person's first name.
        public string FirstName { get; set; }
        // A public string property to store the person's last name.
        public string LastName { get; set; }

        /// <summary>
        /// This is a void method that takes no parameters and prints the
        /// person's full name to the console.
        /// </summary>
        public void SayName()
        {
            // The method uses string interpolation to format and display the full name.
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

}
