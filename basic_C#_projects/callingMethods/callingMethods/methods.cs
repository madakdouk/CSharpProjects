using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace callingMethods
{
    public class Methods
    {
        /*
         * creating first method
         * it takes an int as input and returns int as output
         * addition operator
         */
        public static int Add5(int n)
        {
            //add 5 to input
            return n + 5;
        }

        /*
        * creating next method
        * it takes an int as input and returns int as output
        * multiplication operator
        */
        public static int Times2(int n)
        {
            //multiply by 2
            return n * 2;
        }

        /*
        * creating final method
        * it takes an int as input and returns int as output
        * subtraction operator
        */
        public static int Minus3(int n)
        {
            //subtracts 3 from input
            return n - 3;
        }
    }
}
