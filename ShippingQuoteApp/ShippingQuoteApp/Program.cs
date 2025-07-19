using System;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message and instructions
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user to input the package weight
            Console.Write("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine()); // Convert string input to decimal

            // Check if the package weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // End the program early
            }

            // Prompt user to input package width
            Console.Write("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            // Prompt user to input package height
            Console.Write("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            // Prompt user to input package length
            Console.Write("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Check if total dimensions exceed the allowed limit
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // End the program early
            }

            // Calculate the quote based on dimensions and weight
            decimal quote = (width * height * length * weight) / 100;

            // Display the result formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:0.00}");
            Console.WriteLine("Thank you!");
        }
    }
}
    
