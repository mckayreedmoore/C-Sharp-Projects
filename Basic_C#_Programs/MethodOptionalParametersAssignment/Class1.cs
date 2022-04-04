using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParametersAssignment
{
    class Class1
    {
        public static int multiplyByTwo(int numOne, int numTwo = 1)
        {
            int endNum = numOne * numTwo * 2;
            return endNum;
        }
        
    }
}
