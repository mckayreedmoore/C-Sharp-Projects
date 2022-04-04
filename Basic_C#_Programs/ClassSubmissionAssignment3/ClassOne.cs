using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment3
{
    class ClassOne
    {
        //creation of a new method in ClassOne. Allows for overloading of methodOne
        public void methodOne(int numOne, out int intTwo, int times = 1)
        {
            intTwo = 80;

            for (int i = 0; i < times; i++)
            {
                
                numOne = numOne / 2;
                Console.WriteLine(numOne);
            }
            
            

        }
        
    }
}
