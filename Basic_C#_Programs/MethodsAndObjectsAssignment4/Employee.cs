using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment4
{
    public class Employee : Person, IQuitable
    {
        public  string id { get; set; }

        public void Quit()
        {
            Console.WriteLine("I have had it!! I quit!!!!!!");
        }

        public static bool operator ==(Employee objOne, Employee objTwo)
        {
            return objOne.id == objTwo.id;
        }

        public static bool operator !=(Employee objOne, Employee objTwo)
        {
            return objOne.id != objTwo.id;
        }
    }
}
