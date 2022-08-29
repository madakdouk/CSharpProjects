using twentyoneGame;

internal class Program
{
    public static void Main()
    {
        //creating new object part of deck class
        deck firstDeck = new();
        //shuffling deck
        firstDeck = shuffle(firstDeck);

        //printing out all cards in deck
        foreach (card card in firstDeck.Cards)
        {
            Console.WriteLine(card.Face + " of " + card.Suit);
        }

        //printing out how many cards are in the deck
        Console.WriteLine(firstDeck.Cards.Count);
    }

    //creating shuffle method
    public static deck shuffle(deck deck)
    {
        //creating temp list of cards
        List<card> tempList = new List<card>();
        //creating new random object
        Random random = new Random();

        //loop while input deck cards list is greater than 0
        while (deck.Cards.Count > 0)
        {
            //get random integer between 0 and deck count
            int randomIndex = random.Next(deck.Cards.Count);
            //add card at that index to temp list
            tempList.Add(deck.Cards[randomIndex]);
            //remove card from deck
            deck.Cards.RemoveAt(randomIndex);
        }

        //set deck equal to the temp deck
        deck.Cards = tempList;
        //return deck as output of function
        return deck;
    }
}