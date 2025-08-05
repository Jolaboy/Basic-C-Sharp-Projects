using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOperators
{
    /// <summary>
    /// Represents an employee with an ID, first name, and last name.
    /// </summary>
    public class Employee
    {
        // Public properties for the Employee's data.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Overloads the equality operator (==) to compare two Employee objects.
        /// </summary>
        /// <param name="employee1">The first Employee object to compare.</param>
        /// <param name="employee2">The second Employee object to compare.</param>
        /// <returns>True if the Employee objects' Id properties are equal, otherwise false.</returns>
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check for null values to avoid errors. If both are null, they are considered equal.
            // If one is null and the other isn't, they are not equal.
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
                return true;
            if (ReferenceEquals(employee1, null) || ReferenceEquals(employee2, null))
                return false;

            // Compare the Id properties of the two Employee objects.
            return employee1.Id == employee2.Id;
        }

        /// <summary>
        /// Overloads the inequality operator (!=) to compare two Employee objects.
        /// This is the logical inverse of the equality operator.
        /// </summary>
        /// <param name="employee1">The first Employee object to compare.</param>
        /// <param name="employee2">The second Employee object to compare.</param>
        /// <returns>True if the Employee objects' Id properties are not equal, otherwise false.</returns>
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            // By convention, the inequality operator should be the opposite of the equality operator.
            return !(employee1 == employee2);
        }

        /// <summary>
        /// Overrides the default Equals method. It's good practice to override this
        /// whenever you overload the '==' operator.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>True if the objects are equal based on their Id, otherwise false.</returns>
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and then compare Ids.
            if (obj is Employee otherEmployee)
            {
                return this.Id == otherEmployee.Id;
            }
            return false;
        }

        /// <summary>
        /// Overrides the default GetHashCode method. This is also good practice
        /// when overriding Equals().
        /// </summary>
        /// <returns>A hash code based on the object's Id property.</returns>
        public override int GetHashCode()
        {
            // Use the Id property to generate a consistent hash code.
            return Id.GetHashCode();
        }
    }

}
