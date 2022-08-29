using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * This class is being used in the program twentyoneGame.cs
 * It can be used to create an object representing a deck of cards
 * It has one property which is a list element: Cards
 * It has a constructor method that populates Cards property with a list of a classic 13-faces, 4-suits, 52 total cards objects
 */
namespace twentyoneGame
{
    //class is called deck
    public class deck
    {
        //creating constructor method for class deck
        public deck()
        {
            //upon creating new object from deck class, cards property will consist of a new list containing card elements
            Cards = new List<card>();

            //creating string lists of suits and faces
            List<string> suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> faces = new List<string>
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //populating card list using nested foreach loops
            foreach (string face in faces)
            {
                //for each face value, go to each suit...
                foreach (string suit in suits)
                {
                    //... create a new card object
                    card card = new card();
                    //... with suit property set to current suit in loop
                    card.Suit = suit;
                    //... and with face property set to current face in loop
                    card.Face = face;
                    ///... and finally add the new card to the deck's card list
                    Cards.Add(card);
                }
            }
        }

        //Cards is a property of the deck class that is a list element 
        public List<card> Cards { get; set; }
    }
}
