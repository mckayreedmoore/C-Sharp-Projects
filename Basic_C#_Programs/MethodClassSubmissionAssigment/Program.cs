using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssigment
{
    class Program
    {
         static void  Main(string[] args)
        {
            //initialization of new object frome NewClass. 
            NewClass numClass = new NewClass();

            //Using a method from NewClass without and with naming the variables
            NewClass.newMethod(3, 10);

            NewClass.newMethod(numOne: 89, numTwo: 19023023);

            Console.ReadLine();

        }
    }
}
