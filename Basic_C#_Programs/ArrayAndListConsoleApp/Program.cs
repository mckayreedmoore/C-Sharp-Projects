using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndListConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //creation of a string array array
            int[] intArray = {1, 20, 2, 9, 4848, 32, 3 };

            Console.WriteLine("Welcome to the array program. Pick an index of the array to recieve it's respective information. The first array is an integer array. ");

            //Captures users choice of index and converts it to an integer. 
            int intIndexChoice = Convert.ToInt32(Console.ReadLine());

            //if the indexChoice is a possible choice within the given index, it returns the information found at that index
            if (intIndexChoice < intArray.Length && intIndexChoice >= 0)
            {
                Console.WriteLine(intArray[intIndexChoice]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is not an index in the array. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("This array is a string array.");

            //creation of a string array
            string[] stringArray = { "this", "is", "a","string", "array" };

            //Captures the user's choice and converts it to an integer. 
            int stringIndexChoice = Convert.ToInt32(Console.ReadLine());

            // If the indexChoice is a possible choice within the array, the information held at that index is returned. If not, the user is informed and the program ends. 
            if (stringIndexChoice < stringArray.Length && stringIndexChoice >= 0)
            {
                Console.WriteLine(stringArray[stringIndexChoice]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("That is not an index in the array. Have a good day.");
                Console.ReadLine();
                return;
            }

            List<string> stringList = new List<string>();

            stringList.Add("This");
            stringList.Add("is");
            stringList.Add("a");
            stringList.Add("list");
            stringList.Add("of");
            stringList.Add("strings");

            Console.WriteLine("I now have a list of strings. Pick and index and I will tell you what content is there");
            int userListIndexChoice = Convert.ToInt32(Console.ReadLine());
            if (userListIndexChoice < stringList.Count && userListIndexChoice >= 0)
            {
                Console.WriteLine(stringList[userListIndexChoice]);
            }
            else
            {
                Console.WriteLine("That index doesn't exist in my list.");
            }
            Console.ReadLine();
        
        }
    }
}
