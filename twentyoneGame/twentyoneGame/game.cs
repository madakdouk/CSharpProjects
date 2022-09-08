using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public abstract class game
    {
        //setting the properties of game class
        private List<player> _players = new List<player>();
        public List<player> Players { get { return _players; } set { _players = value; } } // need to get set this way so that list property is not null
        private Dictionary<player, int> _bets = new Dictionary<player, int>();
        public Dictionary<player, int> Bets { get { return _bets; } set { _bets = value; } } //same as list above
        public string Name { get; set; }

        //every inherited class must implement this method
        public abstract void play();

        //method that does not return a value, but prints all players on the screen
        //virtual method can be overwritten to include specific functionality for inherited class
        public virtual void listPlayers()
        {
            foreach (player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
