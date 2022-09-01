using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsObjects
{
    //creating abstract class
    public abstract class person
    {
        //giving class 2 string properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //creating abstract method
        public abstract void sayName();
    }
}
