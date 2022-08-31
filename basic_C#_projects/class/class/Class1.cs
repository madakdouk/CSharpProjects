using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    public class Class1
    {
        //create method that takes 1 int input
        public void method(int n)
        {
            //print out input divided by 2
            Console.WriteLine(n / 2);
        }

        //overloading method, taking string input and returning int value
        public int method(string n)
        {
            //convert string to int 
            int x = Convert.ToInt32(n) * 15;
            //return int value
            return x;
        }
    }
}
