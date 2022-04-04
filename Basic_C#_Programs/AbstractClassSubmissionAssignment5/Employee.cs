using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment5
{
    class Employee : Person
    {

        public void sayName()
        {
            Console.WriteLine(firstName + lastName);
        }
    }
}
