using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Class1
    {

        public static int addNumber(int numOne, int numTwo)
        {
            int numThree = numOne + numTwo;
            return numThree;
        }
        public static int multiplyNumber(int numOne, int numTwo)
        {
            int numThree = numOne * numTwo;
            return numThree;
        }

        public static int divideNumber(int numOne, int numTwo)
        {
            int numThree = numOne / numTwo;
            return numThree;
        }
    }
}
