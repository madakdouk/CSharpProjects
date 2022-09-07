using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parsingEnums
{
    internal class Program
    {
        static void Main()
        {
            //prompting user for input
            Console.WriteLine("Please type in the current day of the week (capitalize the first letter).");

            /* setting up try-catch block to make sure input is valid
             * program will attempt to convert user input to defined enum
             * if value is incorrect, user will need to reenter current day of the week
             */
            try
            {
                //using enum.parse method to parse enum and compare to user input
                DaysOfTheWeek today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine());
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Entered value is not valid. Please try again.");
            }

            Console.Read();
        }
    }

    //creating enum for days of the week
    public enum DaysOfTheWeek 
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
