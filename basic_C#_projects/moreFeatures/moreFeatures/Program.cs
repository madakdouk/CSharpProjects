using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreFeatures
{
    internal class Program
    {
        static void Main()
        {
            const string goat = "Mariah Carey"; //creating const var
            var no1s = 19; //implicit declaration of variable
        }
    }

    public class example
    {
        //setting properties of class
        public string name { get; set; }
        public int id { get; set; }

        //chaining constructors, first is overloaded constructor
        public example (int y) : this("Joe", y) // will set joe as name if none is entered
        {
        }
        public example (string x, int y) //standard constructor
        {
            name = x;
            id = y;
        }
    }
}
