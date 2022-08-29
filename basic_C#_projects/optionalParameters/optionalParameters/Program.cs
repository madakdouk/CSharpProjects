using System;

namespace optionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asking user for input and storing first input as var
            Console.WriteLine("Please input two numbers, one at a time. The second number is optional.");
            int n = Convert.ToInt32(Console.ReadLine());

            //try catch block will use optional parameter in case user does not enter a second value
            try
            {
                //calling method for calculation using user input
                Console.WriteLine("Sum: " + optional.opt(n, Convert.ToInt32(Console.ReadLine())));
            }
            catch (FormatException)
            {
                //if no second input, optional argument will be used
                Console.WriteLine("Sum: " + optional.opt(n));
            }
            Console.Read();
        }
    }
}