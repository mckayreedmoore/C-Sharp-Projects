using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment11
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The exact time right now is " + DateTime.Now + "\nPlease enter a number: ");

            int hourUserInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here is the time hours ahead by the number you specified " + DateTime.Now.AddHours(hourUserInput));

            Console.ReadLine();


        }
    }
}
