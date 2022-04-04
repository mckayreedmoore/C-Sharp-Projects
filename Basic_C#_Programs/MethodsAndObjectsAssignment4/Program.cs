using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation of object from Employee Class
            Employee sampleEmployee = new Employee();
            

            //Assignment of properties from the person class
            Employee.Fname = "Sample ";
            Employee.Lname = "Employee";

            //Declaring of method from the super class, person, to print out first name and last name. 
            Employee.sayName();

            sampleEmployee.Quit();

            Console.ReadLine();


        }
    }
}
