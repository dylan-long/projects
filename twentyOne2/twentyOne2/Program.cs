using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game! whats ya name.");
            String playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring to the table");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                Player player = new Player(playerName, bank );
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playin!");
            }
            Console.WriteLine("bye for now!");
            Console.Read();
        }
    
    }
}
