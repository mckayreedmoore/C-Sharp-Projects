using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates classOne into an object. 
            ClassOne classOneInstance = new ClassOne();

            //gets user input for use as a parameter for the ClassOne methodOne method. 
            Console.WriteLine("Welcome to the program! \nEnter a number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //asks use how many times they would like the method to run, demonstrating overloading of a method
            Console.WriteLine("How many times would you like the method to run? (overloading a method) ");
            int timesAmount = Convert.ToInt32(Console.ReadLine());
            classOneInstance.methodOne(userInput, out int intTwo, timesAmount);

            Console.WriteLine("Here is my output parameter" + intTwo);

            //demonstration of a static class' method.
            StaticClass.uselessMethod();

            Console.ReadLine();
        }
    }
}
