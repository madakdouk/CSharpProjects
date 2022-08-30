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

        //creating shuffle method with optional parameter times to shuffle
        public void shuffle(int times = 1)
        {
            //for loop to shuffle x amount of times
            for (int i = 0; i < times; i++)
            {
                //creating temp list of cards
                List<card> tempList = new List<card>();
                //creating new random object
                Random random = new Random();

                //loop while input deck cards list is greater than 0
                while (Cards.Count > 0)
                {
                    //get random integer between 0 and deck count
                    int randomIndex = random.Next(Cards.Count);
                    //add card at that index to temp list
                    tempList.Add(Cards[randomIndex]);
                    //remove card from deck
                    Cards.RemoveAt(randomIndex);
                }
                //set deck equal to the temp deck
                Cards = tempList;
            }
        }
    }
}
