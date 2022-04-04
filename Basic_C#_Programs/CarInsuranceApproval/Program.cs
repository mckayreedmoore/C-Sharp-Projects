using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome user, ask questions and store answers for later approval consideration

            Console.WriteLine("Hello! Welcome to the insurance approval program. \nWhat is your age?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);

            //Getting DUI data
            Console.WriteLine("Have you ever had a DUI? y/n");
            string duiAnswer = Console.ReadLine();
            

            //Getting speeding ticket data
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTicketStr = Console.ReadLine();
            int speedingTicket = Convert.ToInt32(speedingTicketStr);


            //determining if the user qualifies
            bool doesQualify = age > 15 && duiAnswer == "n" && speedingTicket < 3;

            Console.WriteLine("It is " + doesQualify.ToString() + " that you qualify");
            Console.ReadLine();
        }
    }
}
