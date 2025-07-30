using System;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // This program demonstrates exception handling by dividing two numbers.
                Console.WriteLine("====Exception Handling Example====");
                Console.WriteLine("Please enter a number:");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a number to divide by the number:");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====Dividing NumberOne and numberTwo===");
                Console.WriteLine(numberOne + " divided by " + numberTwo + " is " + (numberOne / numberTwo));
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter a valid number. " + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
