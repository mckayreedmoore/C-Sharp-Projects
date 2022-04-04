using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPayComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            //req 1 - print out introduction
            Console.WriteLine("Anonymous Income Comparison Program");

            //req 2 - greet person 1, get hourly rate and hours worked per week

                //Get hourly rate, convert the string to decimal
            Console.WriteLine("Input hourly rate for person 1");
            string hourRatePersonOneStr = Console.ReadLine();
            decimal hourRatePersonOne = Convert.ToDecimal(hourRatePersonOneStr);

            //Get hours worked a week, convert to int and get hours worked per year
            Console.WriteLine("Input hours worked per week for person 1");
            string weeklyHoursPersonOneStr = Console.ReadLine();
            int weeklyHoursPersonOne = Convert.ToInt32(weeklyHoursPersonOneStr);
            int yearlyHoursPersonOne = weeklyHoursPersonOne * 52;
            decimal personOneSalary = hourRatePersonOne * yearlyHoursPersonOne;

            //req 3 - greet person 2, get hourly rate and hours worked per week

                //Get hourly rate, convert the string to decimal
            Console.WriteLine("Input hourly rate for person 2");
            string hourRatePersonTwoStr = Console.ReadLine();
            decimal hourRatePersonTwo = Convert.ToDecimal(hourRatePersonTwoStr);

            //Get hours worked a week, convert to int and get hours worked per year
            Console.WriteLine("Input hours worked per week for person 2");
            string weeklyHoursPersonTwoStr = Console.ReadLine();
            int weeklyHoursPersonTwo = Convert.ToInt32(weeklyHoursPersonTwoStr);
            int yearlyHoursPersonTwo = weeklyHoursPersonTwo * 52;
            decimal personTwoSalary = hourRatePersonTwo * yearlyHoursPersonTwo;



            // req 4&5 -- print the salaries of both people
            Console.WriteLine("Person one's salary is $" + personOneSalary.ToString());
            Console.WriteLine("Person two's salary is $" + personTwoSalary.ToString());
            

            // req 6 compare the individual yearly salaries
            bool salaryComparison = personOneSalary > personTwoSalary;
            Console.WriteLine("It is " + salaryComparison.ToString() + " that person one makes more than person two");

            Console.ReadLine();

        }
    }
}
