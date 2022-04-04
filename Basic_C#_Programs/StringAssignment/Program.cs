using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //This code demonstrates a string concatenation, the ToUpper() method, and the stringbuilder class
            string concatenate = "Here is a " + "concatenated string" + " do you like it?";
            Console.WriteLine(concatenate);

            concatenate = concatenate.ToUpper();

            Console.WriteLine(concatenate);

            StringBuilder sb = new StringBuilder();

            sb.Append("Here is the first sentence");
            sb.Append("Here is the second sentence");
            sb.Append("Here is the third sentence");
            sb.Append("Here is the last sentence in the paragraph");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
