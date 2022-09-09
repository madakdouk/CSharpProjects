using Casino;
using Casino.twentyoneGame;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Security;
using twentyoneGame;

internal class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the casino. Please let me know what your name is."); //asking for user input
        string playerName = Console.ReadLine();
        if (playerName == "admin") // creating method for admin that will display exceptions on console
        {
            List<ExceptionEntity> exceptions = ReadExceptions(); //this method will get exceptions from db and populate list
            foreach (var exception in exceptions) //this loop will print each exception
            {
                Console.Write(exception.Id + " | ");
                Console.Write(exception.ExceptionType + " | ");
                Console.Write(exception.ExceptionMessage + " | ");
                Console.Write(exception.TimeStamp + " | ");
                Console.WriteLine(); //extra line of space
            }
            Console.Read();
            return;
        }
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
                catch (fraudException ex) //will catch specific exception where user tries to cheat by betting a negative amount
                {
                    Console.WriteLine(ex.Message);
                    updateDBWithException(ex);
                    Console.ReadLine();
                    return; //end program
                }
                catch (Exception ex) //catches any other exceptions that may not have been accounted for
                {
                    Console.WriteLine("An error occurred. Please contact your system administrator.");
                    updateDBWithException(ex);
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

        using (SqlConnection connection = new SqlConnection(connectionString)) //program will use sqlconnection while inside curly braces below
        {
            SqlCommand command = new SqlCommand(queryString, connection); //instantiating new sqlcommand object, input is connection object and queryString
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
    private static List<ExceptionEntity> ReadExceptions()
    {
        string connectionString = @"Data Source=(localdb)\ProjectModels; Initial Catalog = twentyoneGame; 
                                  Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                  TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                  MultiSubnetFailover = False"; //string required to connect to db

        string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions"; //getting info from all columns in db table
        List<ExceptionEntity> exceptions = new List<ExceptionEntity>(); //new list to put data into
        using (SqlConnection connection = new SqlConnection(connectionString)) //creating new connection, passing in connectionString
        {
            SqlCommand command = new SqlCommand(queryString, connection); //creating new sql command, passing in query and connection
            connection.Open(); //opening connection to db
            SqlDataReader reader = command.ExecuteReader(); //this line lets the program read data in table
            while (reader.Read()) //this loop will take data from db and populate list
            {
                ExceptionEntity exception = new ExceptionEntity(); //converting data in sql table to c# types to populate list
                exception.Id = Convert.ToInt32(reader["Id"]);
                exception.ExceptionType = reader["ExceptionType"].ToString().TrimEnd();
                exception.ExceptionMessage = reader["ExceptionMessage"].ToString().TrimEnd();
                exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                exceptions.Add(exception); //adding object to list
            }
            connection.Close(); //closing connection to db
        }
        return exceptions; //return the populated list to the program
    }

}