using System;

namespace MethodsAndObjects
{
    /// <summary>
    /// The Employee class inherits from the Person class. This means it automatically
    /// gets all the properties and methods from Person, such as FirstName, LastName,
    /// and SayName().
    /// </summary>
    public class Employee : Person
    {
        // A public integer property specific to the Employee class.
        public int Id { get; set; }
    }
}
