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

        //overriding sayName method in employee class
        public override void sayName()
        {
            //this line mirrors the code of the virtual function in the abstract class
            base.sayName();
            //this allows you to build more functionality into this function specifically for this class
            //without the need to repeat the "base" code
        }

        //implementing quit method into employee class
        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

    }
}
