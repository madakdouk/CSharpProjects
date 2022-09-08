using twentyoneGame;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the casino. Please let me know what your name is."); //asking for user input
        string playerName = Console.ReadLine();
        Console.WriteLine("How much money will you be playing with today?");
        int bank = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}, would you like to play a game of 21 right now?", playerName);
        string answer = Console.ReadLine().ToLower(); //converting answer to lowercase to make it easier to check
        if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
        {
            player player = new player(playerName, bank); //instantiating new player
            game twenty1 = new twentyOne();
            twenty1 += player; //created new game object and added player to game's list of players
            player.isActivelyPlaying = true;
            while (player.isActivelyPlaying && player.Balance > 0)
            {
                twenty1.play(); //play method is active while player is playing and has money to continue
            }
            twenty1 -= player; //remove player from list when they're done playing
            Console.WriteLine("Thank you for playing!");
        }
        Console.WriteLine("Feel free to take a look around the casino.");
        Console.Read();
    }
}