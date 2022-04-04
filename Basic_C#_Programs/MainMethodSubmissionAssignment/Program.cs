using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of number 20 as an integer, decimal, and string. Passing 20 through doMagic, which will multiply each input by 10. 
            int intNum = 20;
            Console.WriteLine(Class1.doMagic(intNum));

            decimal decNum = 20.0m;
            Console.WriteLine(Class1.doMagic(decNum));

            string strNum = "20";
            Console.WriteLine(Class1.doMagic(strNum));

            Console.ReadLine();
        }
    }
}
