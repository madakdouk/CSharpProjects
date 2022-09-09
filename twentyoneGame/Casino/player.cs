using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class player
    {
        //constructor method
        public player(string name, int beginningBalance)
        {
            Hand = new List<card>();
            Name = name;
            Balance = beginningBalance;
        }

        //properties for player class
        private List<card> _hand = new List<card>();
        public List<card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        //creating method to check if player has sufficient funds for bets
        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough money to bet that high.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //creating overload operator method for add
        public static game operator+ (game game, player player)
        {
            //adds player to game, returns game in new state
            game.Players.Add(player);
            return game;
        }

        //creating overload operator method for subtract
        public static game operator- (game game, player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
