using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mainMethod
{
    public class methods
    {
        //first method takes int input and sends int output
        public int one(int n)
        {
            return n + 1;
        }

        //creating method with same name but slightly different function
        //input is decimal, output is still int
        public int one(decimal n)
        {
            //casting float input to int
            return (int)(n / 2);
        }

        //creating method with same name but slightly different funcntion
        //input is string, output is int
        public int one(string n)
        {
            return Convert.ToInt32(n) - 3;
        }
    }
}
