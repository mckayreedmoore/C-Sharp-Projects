
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
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of Twenty-One?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yea" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                //game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. bye for now!");
            Console.Read();
        }
    }
}
