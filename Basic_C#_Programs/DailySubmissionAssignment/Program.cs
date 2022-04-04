using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailySubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            //requirement 1 - print out title
            Console.WriteLine("The Tech Academy");
            //req 2
            Console.WriteLine("Student Daily Report");
            //req 3 & 4 - as the student a variety of questions, storing their answers in descriptive variables
            Console.WriteLine("What is your name");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? (true/false)");
            string needHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences that you would like to share? Please give specifics.");
            string postiveExperience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you would like to give? Please be specific");
            string studentFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();


            //req 7 - close the program by thanking the students for their answers. Allows time for the student to read the final message
            // before the console closes out. 
            Console.WriteLine("Thank you for your answers. An instructor will respond shortly. Have a great day!");
            Console.ReadLine();



        }
    }
}
