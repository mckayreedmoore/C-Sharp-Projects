using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // App welcome, enter package weight, data manipulation
            Console.WriteLine("Welcome to Package Express. Please follow instructions below.\nEnter package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            //if the package is more than 50 pounds, package express cannot ship, and the user is exited from the application
            if (packageWeight > 50)
            {
                Console.Write("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            //User prompt for package width, height, and length

            Console.WriteLine("What is the package Width?");
            int packageWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package length?");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the package height?");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            //Get the sum of the dimensions and determine if the package can be sent with Package Express
            int dimensionSum = packageWidth + packageLength + packageHeight;

            if (dimensionSum > 50)
            {
                Console.WriteLine("Package too big to be send via Package Express.");
                Console.ReadLine();
                return;
            }

            //Calculate a quote to send the package

            int packageQuote = packageWidth * packageHeight * packageLength * packageWeight / 100;

            Console.WriteLine("Your package will cost to $" + packageQuote + "\nHave a good day!");
            Console.ReadLine();


        }
    }
}
