using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsObjects
{
    internal class Program
    {
        static void Main()
        {
            //instantiating and initializing employee object
            employee employee1 = new employee() { firstName = "Sample", lastName = "Student" };
            //calling method
            employee1.sayName();

            Console.Read();
        }
    }
}
