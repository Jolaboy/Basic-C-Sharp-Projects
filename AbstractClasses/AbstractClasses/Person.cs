using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    /// <summary>
    /// This is an abstract class, which means it cannot be instantiated on its own.
    /// It serves as a blueprint for other classes, such as Employee, to inherit from.
    /// It defines properties and methods that all inheriting classes must implement.
    /// </summary>
    public abstract class Person
    {
        // Public properties to hold the person's first and last name.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// This is an abstract method. It has no implementation here, so
        /// any class that inherits from Person must provide its own implementation.
        /// </summary>
        public abstract void SayName();
    }
}
