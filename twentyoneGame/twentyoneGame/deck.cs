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

            //for loop to create a new deck
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    card card = new card();
                    card.Suit = (Suit)j; //casting int j to Suit enum
                    card.Face = (Face)i;
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
