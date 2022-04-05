using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAssignment12
{
    class Program
    {
        public class printName
        {
            public printName(string theName) : this(theName, 40)
            {
            }
            public printName(string theName, int age)
            {
                Console.WriteLine("Hello my name is {0} and my age is {1}", theName, age);
            }
        }
            
        static void Main(string[] args)
        {
            const string name = "McKay";

            var fullName = "McKay Moore";

            Console.WriteLine("Hello McKay! How old are you?");

            int age;

            try
            {
                 age = Convert.ToInt32(Console.ReadLine());
                 printName thePrint = new printName(fullName, age);
            }
            catch
            {
                 printName thePrint = new printName(fullName);
            }

        

            Console.ReadLine();

        }
    }
}
