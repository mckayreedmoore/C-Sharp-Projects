using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get two numbers from the user, storing them as integers
            Console.Write("Welcome to the program! We are going to do some math. \nEnter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nNow enter another number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            //Using methods to do addition, multiplication, and division on the numbers
            Console.Write("\nHere are your numbers added: ");
            Console.Write(Class1.addNumber(numOne, numTwo));

            Console.Write("\nHere are your numbers multiplied: ");
            Console.Write(Class1.multiplyNumber(numOne, numTwo));

            Console.Write("\nHere are your numbers divided: ");
            Console.Write(Class1.divideNumber(numOne, numTwo));

            Console.ReadLine();


        }
        //These methodss take to int parameters and add, multiply and divide respectively. They then return an integer.
       

    }
}
