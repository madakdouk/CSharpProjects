using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class game
    {
        //setting the properties of game class
        public List<string> players { get; set; }
        public string name { get; set; }
        public string dealer { get; set; }

        //method that does not return a value, but prints all players on the screen
        public void listPlayers()
        {
            foreach (string player in players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
