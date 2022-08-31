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
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        //every inherited class must implement this method
        public abstract void play();

        //method that does not return a value, but prints all players on the screen
        //virtual method can be overwritten to include specific functionality for inherited class
        public virtual void listPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
