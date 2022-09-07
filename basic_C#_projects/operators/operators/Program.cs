using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    internal class Program
    {
        static void Main()
        {
            //instantiating 2 new employee objects and setting id properties
            Employee<string> employee1 = new Employee<string>() { Id = 1 };
            Employee<string> employee2 = new Employee<string>() { Id = 2 };

            //using overload operator methods
            bool equalID = employee1 == employee2;
            bool notEqualID = employee1 != employee2;

            Console.Read();
        }
    }
}

