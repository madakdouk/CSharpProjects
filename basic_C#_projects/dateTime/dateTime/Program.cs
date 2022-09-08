using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("The current date and time is: "+ DateTime.Now); //displaying current date and time to console
            Console.WriteLine("Please enter a number."); //asking for user input
            int hours = Convert.ToInt32(Console.ReadLine()); //storing as var
            Console.WriteLine("In " + hours + " hours, the date and time will be: " + DateTime.Now.AddHours(hours));
            Console.Read();
        }
    }
}
