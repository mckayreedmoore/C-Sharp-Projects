using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter what the current day of the week is.");

                daysOfWeek currentDay = (daysOfWeek)Enum.Parse(typeof(daysOfWeek), Console.ReadLine());
                Console.WriteLine("It is currently " + currentDay.ToString());
                Console.ReadLine();

            }
            
            catch 
            {
                Console.WriteLine("Please enter in a capitalized day of the week");
                Console.ReadLine();
            }
            
        }
    }
    enum daysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
}
