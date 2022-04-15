using System;

namespace dotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome Back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\mckay\OneDrive\Documents\GitHub\C-Sharp Projects\dotNetCore\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\nStudent Score: \n");

            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
