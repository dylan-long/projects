using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyOne2
{
    public class Player
    {   public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet (int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("you dont have enough money to bet that much");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator + (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
