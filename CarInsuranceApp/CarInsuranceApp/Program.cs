using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display program title
            Console.WriteLine("Car Insurance Approval Program");
            Console.WriteLine("------------------------------");

            // Ask for applicant's age
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());  // Convert input to integer

            // Ask if applicant has had a DUI
            Console.Write("Have you ever had a DUI? (true/false): ");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());  // Convert input to boolean

            // Ask how many speeding tickets the applicant has
            Console.Write("How many speeding tickets do you have? ");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());  // Convert input to integer

            // Evaluate qualification rules:
            // Must be older than 15, no DUIs, no more than 3 speeding tickets
            bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

            // Print result of qualification check
            Console.WriteLine("Qualified?");
            Console.WriteLine(isQualified);  // Displays true or false
        }
    }
}
