using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodClass
{
    internal class Program
    {
        static void Main()
        {
            //instantiating the class
            methodClass methods = new methodClass();
            //calling the method and passing in 2 numbers
            methods.method(3, 9);
            //calling the method and specifying paramters by name
            methods.method(x: 7, y: 33);
            Console.Read();
        }
    }
}
