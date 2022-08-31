using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathodsObjects
{
    public class person
    {
        //giving class 2 string properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //creating method that displays name on screen
        public void sayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
