using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class card
    {
        public card()
        {
            Suit = Suit.Spades;
            Face = "Two";
        }
        public Suit Suit { get; set; }
        public string Face { get; set; }
    }

    //creating enum to represent suit
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }
}
