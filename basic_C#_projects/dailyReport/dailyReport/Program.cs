using System;

namespace dailyReport
{
    internal class Program
    {
        static void Main()
        {
            //printing intro to console
            Console.WriteLine("The Tech Academy\nStudent Daily Report\n");

            //asking q1
            Console.WriteLine("What is your Name?");
            //creating var to store answer to q1
            string yourName = Console.ReadLine();

            //asking q2
            Console.WriteLine("\nWhat course are you on?");
            //creating var to store answer to q2
            string yourCourse = Console.ReadLine();

            //asking q3
            Console.WriteLine("\nWhat page number?");
            //creating var to store answer to q3, converting from string to short in one line
            short yourPage = Convert.ToInt16(Console.ReadLine());

            //asking q4
            Console.WriteLine("\nDo you need help with anything? Please answer “true” or “false.”?");
            //creating var to store answer to q4, converting from string to bool in one line
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //asking q5
            Console.WriteLine("\nWere there ay positive experiences you'd like to share? Please give specifics.");
            //creating var to store answer to q5
            string dailyPositive = Console.ReadLine();

            //asking q6
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            //creating var to store answer to q6
            string yourFeedback = Console.ReadLine();

            //asking q7
            Console.WriteLine("\nHow many hours did you study today?");
            //creating var to store answer to q7, converting to byte in one line
            byte yourHours = Convert.ToByte(Console.ReadLine());

            //printing closing message and leaving console open until user decides to exit
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            
        }
    }
}
