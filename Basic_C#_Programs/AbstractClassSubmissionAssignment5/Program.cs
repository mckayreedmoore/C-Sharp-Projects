using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmissionAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee() { firstName = "Sample ", lastName = "Student" };
            newEmployee.sayName();
            Console.ReadLine();
        }
    }
}
