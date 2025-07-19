using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Math Operators

            //Addition
            int total = 5 + 10;
            Console.WriteLine("five plus ten is " + total.ToString());
            Console.ReadLine();

           // Another example
            int total1 = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total1 + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            //Subtraction
            int difference = 10 - 5;
            Console.WriteLine("Five plus ten = " + difference.ToString());
            Console.ReadLine();

           // Multiplication
            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            //Division
            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            int num1 = 200 / 3;
            Console.WriteLine(num1);
            Console.ReadLine();

            //Modulus
            int remainder = 10 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            int remainder1 = 11 % 2;
            Console.WriteLine(remainder1);
            Console.ReadLine();

            //Comparison Operators

            bool trueOrfalse = 13 > 5; // change operator to <
            Console.Write(trueOrfalse.ToString());
            Console.ReadLine();

            int roomTemperature = 68;
            int currentTemperature = 75;

            bool isWarm = currentTemperature > roomTemperature;
            Console.WriteLine("Is currentTemperature greater than roomTemperature? " + isWarm);
            Console.ReadLine();

            roomTemperature = 68;
            currentTemperature = 68;

            isWarm = currentTemperature > roomTemperature;
            Console.WriteLine("Is currentTemperature greater than roomTemperature? " + isWarm);
            Console.ReadLine();

            roomTemperature = 68;
            currentTemperature = 68;

            isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine("Is currentTemperature greater than or equal to roomTemperature? " + isWarm);
            Console.ReadLine();

            roomTemperature = 68;
            currentTemperature = 75;

            isWarm = currentTemperature == roomTemperature;
            Console.WriteLine("Is currentTemperature is equal roomTemperature? " + isWarm);
            Console.ReadLine();

            roomTemperature = 68;
            currentTemperature = 75;

            isWarm = currentTemperature != roomTemperature;
            Console.WriteLine("Is currentTemperature is not roomTemperature? " + isWarm);
            Console.ReadLine();


        }
    }
}
