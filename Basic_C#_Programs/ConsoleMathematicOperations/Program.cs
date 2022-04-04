using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMathematicOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // req 1 - gets number from user and multiplies it by 50
            Console.WriteLine("Welcome to the Math Operations app! \nPlease enter a number that you would like multiplied by 50:");
            string multNumStr = Console.ReadLine();
            int multNum = Int32.Parse(multNumStr);
            int product = multNum * 50;
            Console.WriteLine(product);

            // req 2 - gets a number from user and adds 25 to it
            Console.WriteLine("Give a number you would like 25 added to:");
            string addNumStr = Console.ReadLine();
            int addNum = Int32.Parse(addNumStr);
            int addResult = addNum + 25;
            Console.WriteLine(addResult);

            // req 3 - takes an input from the user, divides it by 12.5 
            Console.WriteLine("Give a number you would like to be divided by 12.5");
            string divideNumStr = Console.ReadLine();
            int divideNum = Int32.Parse(divideNumStr);
            decimal quotient = divideNum / 12.4m;
            Console.WriteLine(quotient);

            // req4 - takes input from the user, checks if it is greater than 50, and gives result to user
            Console.WriteLine("Enter a number and I will tell you if it is greater than 50");
            string compareNumStr = Console.ReadLine();
            int compareNum = Int32.Parse(compareNumStr);
            bool comparison = compareNum > 50;
            Console.WriteLine(comparison.ToString());


            // req 5 - takes input from the user, divides it by 7, and returns the remainder (using modulus)
            Console.WriteLine("Enter a number. I will divide by 7 and return the remainder");
            string modulusNumStr = Console.ReadLine();
            int modulusNum = Int32.Parse(modulusNumStr);
            int modulusResult = modulusNum % 7;
            Console.WriteLine(modulusResult);        





            Console.ReadLine();



        }
    }
}
