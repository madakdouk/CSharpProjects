using System;

namespace whileLoops
{
    internal class Program
    {
        static void Main()
        {
            //displaying intro
            Console.WriteLine("Let's count to five!\n");

            //declaring counter variable
            byte i = 1;

            //loop will be executed while counter is less than 6
            while (i <= 5)
            {
                //print the counter to the console and break to next line
                Console.WriteLine(i+ "\n");
                //update counter
                i++;
            }

            //diplaying next message
            Console.WriteLine("Now, let's continue to count until 10.\n");

            //starting do while loop
            do
            {
                //this loop will continue to count
                Console.WriteLine(i + "\n");
                //updating counter
                i++;
            }
            //it will stop counting after counter is 10
            while (i <= 10);
            Console.Read();
        }
    }
}
