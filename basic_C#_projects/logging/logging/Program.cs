using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace logging
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number."); //asking user for input
            int input = Convert.ToInt32(Console.ReadLine()); //storing input as variable

            using (StreamWriter file = new StreamWriter(@"C:\Users\MDakd\Downloads\logs\logtest.txt", true)) //using streamwriter to add user input to existing txt file
            {
                file.WriteLine(input);
            }

            string output = File.ReadAllText(@"C:\Users\MDakd\Downloads\logs\logtest.txt"); //saving contents of file to string var and displaying on screen
            Console.WriteLine(output);

            Console.Read();
        }
    }
}
