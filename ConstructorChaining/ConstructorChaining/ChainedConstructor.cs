using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChaining
{
    /// <summary>
    /// This class demonstrates constructor chaining. It has two constructors,
    /// and one calls the other using the 'this' keyword.
    /// </summary>
    public class ChainedConstructors
    {
        // Public properties to store values passed to the constructors.
        public string Message { get; set; }
        public int Number { get; set; }

        /// <summary>
        /// This is the primary constructor. It takes two parameters.
        /// </summary>
        /// <param name="message">A string message.</param>
        /// <param name="number">An integer number.</param>
        public ChainedConstructors(string message, int number)
        {
            // Assign the input parameters to the class properties.
            Message = message;
            Number = number;
        }

        /// <summary>
        /// This is the secondary constructor. It takes a single string parameter
        /// and chains to the primary constructor, passing a default value for 'number'.
        /// </summary>
        /// <param name="message">A string message.</param>
        // The 'this(message, 100)' syntax calls the constructor above, passing
        // the provided message and a hardcoded value of 1500.
        public ChainedConstructors(string message) : this(message, 1500)
        {
            // The body of this constructor is empty because all the work
            // is done by the chained constructor.
        }
    }
}
