using System;

namespace mathOperations
{
    internal class Program
    {
        static void Main()
        {
            //asking for user input
            Console.WriteLine("Please enter a number. I will multiply it by 50.");
            //multiplying input by 50
            double num1 = Convert.ToDouble(Console.ReadLine()) * 50;
            //displaying input on console
            Console.WriteLine(num1);

            //asking for user input
            Console.WriteLine("\nPlease enter another number. I will add 25 to it.");
            //adding 25 to input
            double num2 = Convert.ToDouble(Console.ReadLine()) + 25;
            //displaying input on console
            Console.WriteLine(num2);

            //asking for user input
            Console.WriteLine("\nPlease enter another number. I will divide it by 12.5.");
            //diving input by 12.5
            double num3 = Convert.ToDouble(Console.ReadLine()) / 12.5;
            //displaying result on console
            Console.WriteLine(num3);

            //asking for user input
            Console.WriteLine("\nPlease enter another number. I will tell you if it is greater than 50.");
            //checking if input is greater than 50
            bool num4 = Convert.ToDouble(Console.ReadLine()) > 50;
            //displaying result on console
            Console.WriteLine(num4);

            //asking for user input
            Console.WriteLine("\nPlease enter another number. I will divide it by 7 and show you the remainder.");
            //performing modulus operation
            double num5 = Convert.ToDouble(Console.ReadLine()) % 7;
            //displaying result on console
            Console.WriteLine(num5);

            //let user decide when to exit
            Console.ReadLine();
        }
    }
}
