using System;
using System.Collections.Generic;

namespace arrays_lists
{
    internal class Program
    {
        static void Main()
        {
            //creating string array and integer array
            string[] legendsOnly = { "Mariah = icon", "Gaga said \"You were born this way!\"", "Queen Bey" };
            int[] integers = { 3, 7, 9 };

            //creating list of strings
            List<string> strings = new List<string>(3);
            strings.Add("Hello");
            strings.Add("Hi");
            strings.Add("Hey");

            //asking user to select index
            Console.WriteLine("Please select a number to receive a message: \"0\", \"1\", or \"2\"");
            //creating bool to check if input index exists
            bool index1 = false;
            //do while loop will continue to ask for input until valid response is received
            do
            {
                //using try-catch block to catch errors from user input
                try
                {
                    //attempt to print message from index that user input
                    Console.WriteLine(legendsOnly[Convert.ToInt32(Console.ReadLine())]);
                    //set bool to true so do while loop ends
                    index1 = true;
                }
                //if user enters number outside of index range, or enters text, etc
                //this code will execute
                catch (IndexOutOfRangeException)
                {
                    //print this message to explain what is wrong to user
                    Console.WriteLine("Please type in one of the numbers listed above.\n");
                }
            }
            //while loop will end when condition value is false
            while (!index1);

            //asking user to select index
            Console.WriteLine("\nPlease select a number to receive another number: \"0\", \"1\", or \"2\"");
            //creating bool to check if input index exists
            bool index2 = false;
            //do while loop will continue to ask for input until valid response is received
            do
            {
                //using try-catch block to catch errors from user input
                try
                {
                    //attempt to print message from index that user input
                    Console.WriteLine(integers[Convert.ToInt32(Console.ReadLine())]);
                    //set bool to true so do while loop ends
                    index2 = true;
                }
                //if user enters number outside of index range, or enters text, etc
                //this code will execute
                catch (IndexOutOfRangeException)
                {
                    //print this message to explain what is wrong to user
                    Console.WriteLine("Please type in one of the numbers listed above.\n");
                }
            }
            //while loop will end when condition value is false
            while (!index2);

            //asking user to select index
            Console.WriteLine("\nPlease select a number to receive a greeting: \"0\", \"1\", or \"2\"");
            //creating bool to check if input index exists
            bool index3 = false;
            //do while loop will continue to ask for input until valid response is received
            do
            {
                //using try-catch block to catch errors from user input
                try
                {
                    //attempt to print message from index that user input
                    Console.WriteLine(strings[Convert.ToInt32(Console.ReadLine())]);
                    //set bool to true so do while loop ends
                    index3 = true;
                }
                //if user enters number outside of index range, or enters text, etc
                //this code will execute
                catch (ArgumentOutOfRangeException)
                {
                    //print this message to explain what is wrong to user
                    Console.WriteLine("Please type in one of the numbers listed above.\n");
                }
            }
            //while loop will end when condition value is false
            while (!index3);

            //keep program open until user presses a key
            Console.Read();
        }
    }
}
