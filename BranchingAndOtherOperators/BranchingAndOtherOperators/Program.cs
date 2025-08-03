using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndOtherOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // Branching and Other Operators

        // Example:
        if (true)
            {
                Console.WriteLine("This is Branching in C#");
            }

        // If/Else Statements
        if (1 == 1)
            {
                Console.WriteLine("1 is equal to 1");
            }
        else
            {
                Console.WriteLine("1 is not equal to 1");
            }

            // Another Example of If/Else
            string name = "Amadou";
            if (name == "Amadou")
            {
                Console.WriteLine("Hello Amadou");
            }
            else
            {
                Console.WriteLine("Hello Stranger");
            }

            // Another Example:
            string otherName = "Omar";
            if (otherName == "Bob")
            {
                Console.WriteLine("Hello " + otherName);
            }
            else if (otherName == "Peter")
            {
                Console.WriteLine("Your name is Bob");
            }
            else
            {
                Console.WriteLine("You're neither Bob nor peter");
            }

            // Ternary Operator Example:
            int age = 19;
            string ageMessage = age >= 18 ? "You are an adult" : "Your are not an adult";
            Console.WriteLine(ageMessage);

            int num1 = 8;
            int num2 = 11;
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";
            Console.WriteLine(result);

            // Switch Statement Example:
            int day = 5;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            // Outputs "Thursday" (day 4)


        }
    }
}
