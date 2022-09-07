using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structs
{
    internal class Program
    {
        static void Main()
        {
            Number number1 = new Number() { amount = 100m }; //instantiated new number object, gave amount property a value
            Console.WriteLine(number1.amount); //printing amount to screen
            Console.Read();
        }
    }

    public struct Number //creating struct called number
    {
        public decimal amount { get; set; } //giving struct a decimal type property
    }
}
