using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ask user for their age. Cast their input to an integer. If the age is less than 0, throw an exception. Take their age and subtract it from the current year. Guess their birthyear. 
                Console.WriteLine("What will be your age this year?");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0)
                {
                    throw new Exception();
                }
                int birthYear = 2022 - age;
                Console.WriteLine("Let me guess... \nYou were born in {0}", birthYear);
                Console.ReadLine();
            }
            
            catch (Exception)
            {
                Console.WriteLine("Type only Numbers. You can't have 0 age or negative numbers either!");
            }


            
        }
    }
}
