using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program compares the annual salaries of two persons based on their hourly rates and hours worked per week.

            // Printing the title of the program
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("=====================================");

            // Prompting for input and calculating the annual salaries of two persons

            // Prompts for Person 1
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            decimal person1HourlyRate = Convert.ToDecimal(Console.ReadLine()); //Get and Convert Hourly Rate

            Console.WriteLine("Hours worked per week: ");
            int person1HoursPerWeek = Convert.ToInt32(Console.ReadLine()); // Get and Convert Hours Worked Per Week

            // Calculate annual salary for Person 1
            decimal person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52; // Assuming 52 weeks in a year
            Console.WriteLine("Annual salary of Person 1: " + person1AnnualSalary);

            // Prompts for Person 2
            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            decimal person2HourlyRate = Convert.ToDecimal(Console.ReadLine()); // Get and Convert Hourly Rate

            Console.WriteLine("Hours worked per week: ");
            int person2HoursPerWeek = Convert.ToInt32(Console.ReadLine()); // Get and Convert Hours Worked Per Week

            // Calculate annual salary for Person 2
            decimal person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52; // Assuming 52 weeks in a year
            Console.WriteLine("Annual salary of Person 2: " + person2AnnualSalary);

            // Display annual salaries
            Console.WriteLine("\nAnnual Salary of Person 1:");
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine("\nAnnual Salary of Person 2:");
            Console.WriteLine(person2AnnualSalary);

            // Compare annual earnings and display the result
            Console.WriteLine("\nDoes Person 1 makes more money than Person 2?:");
            Console.WriteLine(person1AnnualSalary > person2AnnualSalary); // Outputs True or False


            
            

        }
    }
}
