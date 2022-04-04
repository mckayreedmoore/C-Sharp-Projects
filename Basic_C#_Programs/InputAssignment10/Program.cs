using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace InputAssignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for a number
            Console.WriteLine("Welcome to the program! \nPlease input a number: ");

            //stores number as a string input
            string userInput = Console.ReadLine();

            //saves the string input as a file
            File.WriteAllText(@"C:\Users\mckay\OneDrive\Documents\GitHub\C-Sharp Projects\Basic_C#_Programs\inputAssignment.txt", userInput);

            
            Console.WriteLine("The number will now be sent back to you.");
            Console.ReadLine();


            //reads the aforementioned file back to the user
            Console.WriteLine(File.ReadAllText(@"C:\Users\mckay\OneDrive\Documents\GitHub\C-Sharp Projects\Basic_C#_Programs\inputAssignment.txt"));

            Console.ReadLine();


        }
    }
}
