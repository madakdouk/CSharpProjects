using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
        static void Main()
        {
            //instantiating the class
            Class1 method = new Class1();
            //asking user for input and storing as variable
            Console.WriteLine("Please enter a number. It will be divided by 2.");
            int x = Convert.ToInt32(Console.ReadLine());
            //calling method
            method.method(x);
            //calling method with output parameter
            staticClass.method(out x);
            //asking for input and calling overloaded method
            Console.WriteLine("Please enter another number. It will be multiplied by 15.");
            //printing result
            Console.WriteLine(method.method(Console.ReadLine()));
            Console.Read();
        }
    }
}
