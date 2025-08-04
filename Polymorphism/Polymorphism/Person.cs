using System;

namespace Polymorphism
{
    /// <summary>
    /// This is the abstract base class. It cannot be instantiated on its own.
    /// It provides a common blueprint for classes like Employee.
    /// </summary>
    public abstract class Person
    {
        // Public properties to hold the person's first and last name.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// This is an abstract method that must be implemented by any
        /// concrete class that inherits from Person.
        /// </summary>
        public abstract void SayName();
    }

}
