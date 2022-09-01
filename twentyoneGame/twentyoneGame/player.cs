using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class player
    {
        //properties for player class
        public List<card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
