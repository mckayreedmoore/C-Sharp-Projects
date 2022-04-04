using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndLoopsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // creation of a list of strings, get user input for what to add into the list. 
            string[] stringArray = { "Here", "is", "an", "array", "of", "strings" };

            Console.WriteLine("Welcome. Please provide text that will be added item of a predetermined list. \n Write the text you would like to add:");
            string userTextInput = Console.ReadLine();

            //iterates through each index on the array of strings, and concatenates the string array to the user input, saving it over the original input on the list
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] = stringArray[i] + userTextInput;
            }

            //prints the new modifed list
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
            

            //demonstrates use of a while loop that has a definitive number of loops. Uses symbol <=
            int z = 0;
            while ( z <=8)
            {
                Console.WriteLine("This should print out nine times");
                z++;
            }
            Console.ReadLine();

            //demonstrates use of a while loop that has a definitive number of loops. Uses symbol <
            int l = 0;
            while (l < 8)
            {
                Console.WriteLine("This should print out eight times");
                l++;
            }

            Console.ReadLine();

            //creates a list of strings
            List<string> uniqueList = new List<string>();
            uniqueList.Add("John");
            uniqueList.Add("McKay");
            uniqueList.Add("Ashton");
            uniqueList.Add("Henry");
            uniqueList.Add("Joe");
            uniqueList.Add("Paul");

            Console.WriteLine("Hello! I have created a list of names. Guess a name in the list:");

            string nameGuess = Console.ReadLine();

            //takes nameGuess user input and iterates through uniqueList to determine if the user input matches one of the names in the list. Prints out result each time. If there is a match between the user input and the index content, the for loop ends. 
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i] == nameGuess)
                {
                    Console.WriteLine("You are right! The name you guessed was at index " + i);
                    break;
                }
                else
                {
                    Console.WriteLine("Guess did not match index " + i);
                }
            }

            Console.ReadLine();

            //creation of list nameList
            List<string> nameList = new List<string>();
            nameList.Add("John");
            nameList.Add("McKay");
            nameList.Add("Ashton");
            nameList.Add("McKay");
            nameList.Add("Joe");
            nameList.Add("Paul");

            Console.WriteLine("I have made another list of names. Guess a name again.");

            string nameGuessTwo = Console.ReadLine();
            
            //takes user input and iterates through nameList, telling the user if their guess matches the index content. 
            for (int j = 0; j < nameList.Count; j++)
            {
                if (nameList[j] == nameGuessTwo)
                {
                    Console.Write("\nYou are correct! You guess matches the name at index " + j);
                }
                else
                {
                    Console.Write("\nIncorrect guess for index " + j);
                }
            }
            Console.ReadLine();

            Console.WriteLine("\nI have one more list! Click any key to see what happens.");
            Console.ReadLine();

            //creation of nameListThree
            List<string> nameListThree = new List<string>();
            nameListThree.Add("John");
            nameListThree.Add("McKay");
            nameListThree.Add("Ashton");
            nameListThree.Add("McKay");
            nameListThree.Add("Joe");
            nameListThree.Add("Ashton");

            //creation of evauluationList and repeatedEntry. These will enable us to determine if there was an earlier entry that matches a current entry when the list is iterated through. 
            List<string> evaluationList = new List<string>();
            bool repeatedEntry = false;
          
            //Iterates through each item on the list and comares it to each item on the evaluationList. If the there is a match between the current index and an item on the evaluation list, the repeatedEntry boolean is set to true. The current index is then added to evaluationList. If repeatedEntry is true, it is printed out the console and then repeatedEntry is assigned false again in order to ensure accurate comparison in the rest of the list. 
            foreach (string name in nameListThree)
            {
                foreach (string compareName in evaluationList)
                {
                    if (compareName == name)
                    {
                        repeatedEntry = true;
                    }
                }
                evaluationList.Add(name);
                if (repeatedEntry == true)
                {
                    Console.Write("\n\"" + name + "\" is repeated earlier in the list");
                    repeatedEntry = false;
                } 
                else
                {
                    Console.Write("\n\"" + name + "\" has no earlier repeats");
                }
                
            }
            Console.ReadLine();
        }

        
    }
}
