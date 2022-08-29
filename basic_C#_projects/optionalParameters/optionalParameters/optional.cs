using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace optionalParameters
{
    public class optional
    {
        //creatig method that will take 2 parameters, but one is optional
        public static int opt(int n, int m = 1)
        {
            //output will be sum of arguments
            return n + m;
        }
    }
}
