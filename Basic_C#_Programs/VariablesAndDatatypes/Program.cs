using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// This is a simple program
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is " + yourName);
            //Console.ReadLine();
            //Console.WriteLine("What is your name?");

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //Console.WriteLine("Your favorite number is " + favoriteNumber);
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemperature = -23;
            char randomLetter = '\u2103';

            //Console.WriteLine(randomLetter);
            //Console.ReadLine();

            decimal moneyInBank = 100.5m;

            double heightInCentimeters = 211.30234232;

            float secondsLeft = 2.62f;

            short temperatureOnMars = -341;

            string myName = "McKay";

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);




            int num1 = 3;
            int num2 = 5;

            int add = num1 + num2;
            int subtract = num1 - num2;
            int multiply = num1 * num2;
            int divide = num1 / num2;

            //Console.WriteLine(add);
            //Console.WriteLine(subtract);
            //Console.WriteLine(multiply);
            //Console.WriteLine(divide);
            //Console.ReadLine();

            string myFName = "McKay ";
            string myLName = "Moore";

            Console.WriteLine(myFName + myLName);
            Console.ReadLine();

        }
    }
}
