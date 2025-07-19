using System; // Import System namespace for basic functionalities
using System.Text;  // Import StringBuilder namespace
using System.Threading.Tasks; // Import Task namespace for asynchronous programming

namespace StringsAndStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ========== STRING CONCATENATION ==========
            // Define three separate strings
            string firstName = "Amadou";
            string middleName = "Kawsu";
            string lastName = "Jarju";

            // Concatenate the strings into a full name
            string fullName = firstName + " " + middleName + " " + lastName;

            // Display the result
            Console.WriteLine("Full Name (Concatenation): " + fullName);


            // ========== CONVERT STRING TO UPPERCASE ==========
            // Convert the full name to uppercase letters
            string upperName = fullName.ToUpper();

            // Display the uppercase version
            Console.WriteLine("Full Name in Uppercase: " + upperName);


            // ========== PARAGRAPH WITH STRINGBUILDER ==========
            // Initialize a new StringBuilder to build a paragraph
            StringBuilder paragraph = new StringBuilder();

            // Append sentences one at a time to build a full paragraph
            paragraph.Append("Amadou is a full-stack developer passionate about React and ASP.NET Core. ");
            paragraph.Append("He enjoys building aesthetic, functional, and scalable web applications. ");
            paragraph.Append("His projects often include GitHub-hosted repositories, clean UI/UX, and modern design patterns. ");
            paragraph.Append("He's constantly refining his skills, eager to tackle new challenges and collaborate with peers. ");

            // Print the resulting paragraph to the console
            Console.WriteLine("\nGenerated Paragraph:");
            Console.WriteLine(paragraph.ToString());

        }
    }
}
