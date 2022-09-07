using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twentyoneGame
{
    public class card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }

    //creating enums to represent suits and faces
    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
