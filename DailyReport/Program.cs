using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print the name of the college and the title of the report  
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            // ---Data Collection--  

            // Ask for the student name and store it as a string  
            Console.WriteLine("What is your name? ");
            string studentName = Console.ReadLine();

            // Ask for the course the student is on and store it as a string  
            Console.WriteLine("What course are you on? ");
            string courseName = Console.ReadLine();

            // Ask for the current page number and convert it to an integer  
            // It uses a a loop with TryParse to handle potential invalid input (non-integer).  
            int pageNumber;
            while (true)
            {
                Console.WriteLine("What page number are you on? ");
                string pageNumberstr = Console.ReadLine();
                if (int.TryParse(pageNumberstr, out pageNumber))
                {
                    Console.WriteLine("You are on page " + pageNumber + ".");
                    break; // Exit the loop when input is valid  
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid page number.");
                }
            }

            // Ask if the student needs help and convert the input to a boolean (True/False).  
            // The input is converted to lowercase for case-insensitive comparison.  
            bool needsHelp;
            while (true)
            {
                Console.Write("Do you need help with anything? Please answer “true” or “false”. ");
                string needsHelpInput = Console.ReadLine().ToLower();
                if (needsHelpInput == "true")
                {
                    needsHelp = true;
                    Console.WriteLine("Thank you for letting us know. We will assist you."); // Use the variable  
                    break;
                }
                else if (needsHelpInput == "false")
                {
                    needsHelp = false;
                    Console.WriteLine("Great! Let us know if you need help later."); // Use the variable  
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please answer 'true' or 'false'.");
                }
            }

            // Ask for any positive feedback and store it as a string  
            Console.WriteLine("there any positive experiences you’d like to share? Please give specifics.\r\n");
            string positiveExperiences = Console.ReadLine();

            // ask for any other feedback and store it as a string  
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            // Ask how many hours the student studied today and store it as an integer  
            float studyHours;
            while (true)
            {
                Console.Write("How many hours did you study today? ");
                string studyHoursStr = Console.ReadLine();
                // Attempt to parse the string to a float.  
                if (float.TryParse(studyHoursStr, out studyHours))
                {
                    break; // Exit the loop if parsing is successful  
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number for hours studied (e.g., 2.5, 3).");
                }
            }

            // --- Report Summary (Optional, but good for verification) ---
            // This section is commented out as the prompt only asks for the closing message after questions.
            // However, in a real application, you might want to print a summary of the collected data.

            Console.WriteLine("\n--- Report Summary ---");
            Console.WriteLine($"Student Name: {studentName}");
            Console.WriteLine($"Course: {courseName}");
            Console.WriteLine($"Page Number: {pageNumber}");
            Console.WriteLine($"Needs Help: {needsHelp}");
            Console.WriteLine($"Positive Experiences: {(string.IsNullOrEmpty(positiveExperiences) ? "None shared." : positiveExperiences)}");
            Console.WriteLine($"Other Feedback: {(string.IsNullOrEmpty(otherFeedback) ? "None shared." : otherFeedback)}");
            Console.WriteLine($"Hours Studied: {studyHours}");

            // Print the closing message to the student.
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

        }
    }
}
