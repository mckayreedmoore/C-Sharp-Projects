using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //start of the try block 
            try
            {
                //creation of an integer list
                List<int> intList = new List<int>();
                intList.Add(8);
                intList.Add(3);
                intList.Add(41);
                intList.Add(43);
                intList.Add(17);

                //welcomes user to program, gets integer user input
                Console.WriteLine("Welcome to the program. Enter a divisor for a set of numbers in a list");
                int userIntChoice = Convert.ToInt32(Console.ReadLine());

                //takes user integer input and divides each number in the intList by it, printing out the quotient following. 
                foreach (int number in intList)
                {
                    int quotient = number / userIntChoice;
                    Console.WriteLine(quotient);
                }
            }

            //exception catches for two common exceptions, dividing by zero, and incorrect format input
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Type only integers in.");

            }

            //Ensures that all messages can be read as this is the last thing the program does. 
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
