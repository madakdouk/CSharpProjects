using System;

namespace carInsurance
{
    internal class Program
    {
        static void Main()
        {
            //print intro message
            Console.WriteLine("Auto Insurance\nPlease answer the following questions to find out if you're approved.\n");

            //ask about age, DUIs, and speeding tickets
            //store answers as variables
            Console.WriteLine("What is your age? Please enter a number below.");
            byte age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please enter \"true\" or \"false\" below.");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have? Please enter a number below.");
            byte speeding = Convert.ToByte(Console.ReadLine());

            //compare user input variables to qualification requirements
            bool qualify = (age > 15 && dui == false && speeding < 4);
            //print result
            Console.WriteLine("\nQualified?\n"+qualify);
            Console.ReadLine();
        }
    }
}
