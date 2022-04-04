using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Number objOne = new Number();
            objOne.Amount = 34.2m;

            Console.WriteLine(objOne.Amount);
            Console.ReadLine();
        }
    }

    public struct Number
    {
        public decimal Amount;
    }

}
