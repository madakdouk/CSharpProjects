using System;

namespace optionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //calling method with only 1 argument passed to it
            Console.WriteLine("1 + 1 = " + optional.opt(1));

            //calling method with 2 arguments passed to it
            Console.WriteLine("4 + 6 = " + optional.opt(4, 6));

            Console.Read();
        }
    }
}