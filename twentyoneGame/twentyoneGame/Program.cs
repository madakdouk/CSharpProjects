using Casino;
using Casino.twentyoneGame;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Security;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the casino. Please let me know what your name is."); //asking for user input
        string playerName = Console.ReadLine();
        bool validAnswer = false; //variable to check upcoming user input
        int bank = 0; //variable that will eventually store betting amount
        while (!validAnswer) //this loop will run until valid answer is true
        {
            Console.WriteLine("How much money will you be playing with today?"); //asking for user input
            //tryparse will attempt to convert string input to int, if it succeeds then bool will be true, loop will end, bet will be stored
            validAnswer = int.TryParse(Console.ReadLine(), out bank);
            if (!validAnswer) Console.WriteLine("Please enter numeric digits only and no decimals.");
        }
        Console.WriteLine("{0}, would you like to play a game of 21 right now?", playerName);
        string answer = Console.ReadLine().ToLower(); //converting answer to lowercase to make it easier to check
        if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
        {
            player player = new player(playerName, bank); //instantiating new player and id
            player.id = Guid.NewGuid();
            using (StreamWriter file = new StreamWriter(@"C:\Users\MDakd\Downloads\logs\logtest3.txt", true))
            {
                file.WriteLine(player.id); //logging player's id in txt file
            }
            game twenty1 = new twentyOne();
            twenty1 += player; //created new game object and added player to game's list of players
            player.isActivelyPlaying = true;
            while (player.isActivelyPlaying && player.Balance > 0)
            {
                try //using try-catch to catch any exceptions
                {
                    twenty1.play(); //play method is active while player is playing and has money to continue
                }
                catch (fraudException) //will catch specific exception where user tries to cheat by betting a negative amount
                {
                    Console.WriteLine("Security! Kick this person out.");
                    Console.ReadLine();
                    return; //end program
                }
                catch (Exception) //catches any other exceptions that may not have been accounted for
                {
                    Console.WriteLine("An error occurred. Please contact your system administrator.");
                    return;
                }
            }
            twenty1 -= player; //remove player from list when they're done playing
            Console.WriteLine("Thank you for playing!");
        }
        Console.WriteLine("Feel free to take a look around the casino.");
        Console.Read();
    }
    private static void updateDBWithException(Exception ex)
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels; Initial Catalog = twentyoneGame; 
                                  Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                  TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                  MultiSubnetFailover = False"; //this string is required for the program to connect to the db

        string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                               (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //this is the SQL query, there are placeholders for now

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
            command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
            command.Parameters.Add("@TimeStamp", SqlDbType.DateTime); //adding data type of placeholders in query string

            command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
            command.Parameters["@ExceptionMessage"].Value = ex.Message;
            command.Parameters["@TimeStamp"].Value = DateTime.Now; //adding values of placeholders

            connection.Open(); //open connection to db
            command.ExecuteNonQuery(); //execute command, it is nonquery bc we are inserting, not searching thru db
            connection.Close(); //close connection to db
        }
    }
}