using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsObjects
{
    //this class inherits from person class
    public class employee : person, IQuittable
    {
        //new property for this class
        public int id { get; set; }

        //implementing abstract method here
        public override void sayName()
        {
            //printing employee name to screen
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //implementing quit method into employee class
        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

    }
}
