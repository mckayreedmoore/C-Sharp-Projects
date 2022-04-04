using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment4
{
    public class Person
    {
        //Creation of properties in person class
        public static string Fname { get; set; }
        public static string Lname { get; set; }

        //creation of method for person class
        static public void sayName()
        {
            Console.WriteLine("Name: " + Person.Fname + Person.Lname);
        }


    }
}
