
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino1;
using Casino1.TwentyOne;

namespace TwentyOneCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino! \nWhat is your name?");
            string playerName = Console.ReadLine();
            

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And How much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals");
            }

            
            Console.WriteLine("Hello, {0}. Would you like to join a game of Twenty-One?", playerName);


            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yea" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\mckay\OneDrive\Documents\GitHub\C-Sharp Projects\Basic_C#_Programs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }
                game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch(FraudException)
                    {
                        Console.WriteLine("Security! Kick this person out! They are trying to cheat the system!");
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occurred. Please contact your system administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
                }
                //game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. bye for now!");
            Console.Read();
        }
    }
}
