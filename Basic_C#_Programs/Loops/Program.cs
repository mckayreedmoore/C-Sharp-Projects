using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            //a do while loop that runs until the number = 12

            bool isGuessed = number == 12;
            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You guessed 12. That is correct!!");
                        break;
                    default:
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("You are wrong.");
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();

            int counter = 0; 

            while (counter < 10)
            {
                Console.WriteLine("You won!");
                counter++;
            }

            Console.ReadLine();
        }
    }
}
