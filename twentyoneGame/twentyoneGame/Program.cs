using twentyoneGame;

internal class Program
{
    public static void Main()
    {
        //creating new object part of deck class
        deck firstDeck = new();
        //shuffling deck
        firstDeck.shuffle(3);

        //printing out all cards in deck
        foreach (card card in firstDeck.Cards)
        {
            Console.WriteLine(card.Face + " of " + card.Suit);
        }

        //printing out how many cards are in the deck
        Console.WriteLine(firstDeck.Cards.Count);
    }
}