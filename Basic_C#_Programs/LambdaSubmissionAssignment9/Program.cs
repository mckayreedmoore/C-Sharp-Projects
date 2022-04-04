using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment9
{
    class Program
    {
       

        static void Main(string[] args)
        {
            //Creation of the Employee class as a list. 
            List<Employee> employeeList = new List<Employee>();


            //Creating employee objects and then adding them to the list. 
            employeeList.Add(new Employee { Fname = "Joe", Lname = "Stewart", id = 1 });
            employeeList.Add(new Employee { Fname = "Henry", Lname = "Johnson", id = 2 });
            employeeList.Add(new Employee { Fname = "Pam", Lname = "Moore", id = 3 });
            employeeList.Add(new Employee { Fname = "Jennifer", Lname = "Gilbert", id = 4 });
            employeeList.Add(new Employee { Fname = "Stacy", Lname = "Jensen", id = 5 });
            employeeList.Add(new Employee { Fname = "Dai", Lname = "Xiong", id = 6 });
            employeeList.Add(new Employee { Fname = "Jens", Lname = "Hutchinson", id = 7 });
            employeeList.Add(new Employee { Fname = "Joe", Lname = "Mama", id = 8 });
            employeeList.Add(new Employee { Fname = "William", Lname = "Wentworth", id = 9 });
            employeeList.Add(new Employee { Fname = "Elizabeth", Lname = "Charles", id = 10 });

            //instantiation of a new list, joeList
            List<Employee> joeList = new List<Employee>();

            //Adding all employees from employeeList that have the first name of "joe" using a foreach iteration loop
            foreach (Employee employee in employeeList)
            {
                if (employee.Fname == "Joe")
                {
                    joeList.Add(employee); 
                }
            }

            //Adding all the employees that have the first name of "joe" using a lambda function
            List<Employee> joeListTwo = employeeList.Where(x => x.Fname == "Joe").ToList();

            //Adding all the employees that have an id of greater than 5 using a lambda function
            List<Employee> idList = employeeList.Where(x => x.id > 5).ToList();

            //Describing and then displaying all the unique lists that were created during this assignment. 
            Console.WriteLine("\nHere is the entire list of employees\n");

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee.Fname + " " + employee.Lname + " " + employee.id);
            }

            Console.WriteLine("\nHere is the list of employees with the first name of joe\n");

            foreach (Employee joeEmployee in joeList)
            {
                Console.WriteLine(joeEmployee.Fname + " " + joeEmployee.Lname + " " + joeEmployee.id);
            }

            Console.WriteLine("\nHere is the list of employees with an id of greater than 5\n");

            foreach (Employee idEmployee in idList)
            {
                Console.WriteLine(idEmployee.Fname + " " + idEmployee.Lname + " " + idEmployee.id);
            }
       
            Console.ReadLine();
        }
    }
    //creation of the Employee class. 
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int id { get; set; }
    }
}
