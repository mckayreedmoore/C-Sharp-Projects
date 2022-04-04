using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParametersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user! In this program you will enter \ntwo numbers. The second number is optional. The first \nnumber you input will be multiplied by two. If you chose to \nenter the second number, the number will be multiplied by \nthat as well. \nEnter the first number: ");
            int firstUserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to enter in a second number? y/n");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "y")
            {
                Console.WriteLine("\nNow enter your second number. ");
                int secondUserInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Here is the result");
                Console.WriteLine(Class1.multiplyByTwo(firstUserInput, secondUserInput));
            }
            else
            { 
                Console.WriteLine("Here is the result");
                Console.WriteLine(Class1.multiplyByTwo(firstUserInput));
            }
            
            

            Console.ReadLine();


        }
    }
}
