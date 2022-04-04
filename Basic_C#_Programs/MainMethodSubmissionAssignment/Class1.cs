using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Class1
    {

        // creation of methods of Class1 class that take a integer, decimal, and a string representing a number and mutlipy them by 10 respectively
        static public int doMagic(int number)
        {
            int theNum = number * 10;
            return theNum;
        }

        static public int doMagic(decimal number)
        {
            int theNum = Convert.ToInt32(number * 10);
            return theNum;
        }

        static public int doMagic(string numberStr)
        {
            int number = Convert.ToInt32(numberStr);
            int theNum = number * 10;
            return theNum;
        }
    }
}
