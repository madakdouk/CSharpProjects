using twentyoneGame;

internal class Program
{
    public static void Main()
    {
        //creating new game and instantiating list of players
        game game = new twentyOne();
        game.Players = new List<player>();
        //creating new player
        player player = new();
        player.Name = "Maher";
        //adding player to game using overload operator +
        game += player;


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

        Console.ReadLine();
    }
}