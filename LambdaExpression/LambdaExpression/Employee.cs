using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    /// <summary>
    /// Represents an employee with an Id, first name, and last name.
    /// This class serves as a blueprint for creating employee objects.
    /// </summary>
    public class Employee
    {
        // Public properties for employee data.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
