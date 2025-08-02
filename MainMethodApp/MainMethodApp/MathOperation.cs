using System; // Required for data types like int and decimal

namespace MainMethod
{
    /// <summary>
    /// This class contains three overloaded methods with the same name,
    /// each performing a different math operation.
    /// </summary>
    public class MathOperations
    {
        /// <summary>
        ///  This is the first method, which takes an integer, multiplies it,
        /// and returns an integer result.
        /// </summary>
        /// <param name="number">An integer to be multiplied.</param>
        /// <returns>The result of the multiplication as an integer.</returns>
        public int PerformOperation(int number)
        {
            // The method multiplies the input number by 10.
            return number * 10;
        }

        /// <summary>
        /// This is the second method, which takes a decimal, adds a value,
        /// and returns an integer result.
        /// </summary>
        /// <param name="number">A decimal number to have a value added to it.</param>
        /// <returns>The result of the addition, converted to an integer.</returns>
        public int PerformOperation(decimal number)
        {
            // Add 15 to the decimal number and then cast the result to an integer.
            // Casting discards any fractional part of the decimal.
            return (int)(number + 15.0m);
        }

        /// <summary>
        /// This is the third method, which takes a string, converts it to an integer,
        /// performs a subtraction, and returns an integer result.
        /// </summary>
        /// <param name="number">A string that can be converted to an integer.</param>
        /// <returns>The result of the subtraction as an integer.</returns>
        public int PerformOperation(string number)
        {
            // Declare an integer to hold the converted value.
            int convertedNumber;

            // Try to parse the string input to an integer.
            // This is a safe way to convert a string to a number.
            if (int.TryParse(number, out convertedNumber))
            {
                // If the conversion is successful, subtract 5 from the number.
                return convertedNumber - 5;
            }
            else
            {
                // If the string cannot be converted to a number,
                // return a default value (e.g., 0) and print an error message.
                Console.WriteLine("Warning: The string input was not a valid number. Returning 0.");
                return 0;
            }
        }
    }
}
