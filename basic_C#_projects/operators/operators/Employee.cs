using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators
{
    public class Employee
    {
        //creating properties for employee class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //overload == operator, takes 2 employee objects and returns bool
        public static bool operator== (Employee emp1, Employee emp2)
        {
            //checking if ids are equal
            bool equalID = emp1.Id == emp2.Id;
            //print message based on result
            if (equalID) { Console.WriteLine("The employees have the same ID number."); }
            else { Console.WriteLine("The employees have unique ID numbers."); }
            //return bool value: true if equal, false if not
            return equalID;
        }

        //overload != operator, takes 2 employeee objects and reutrns bool
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            //check if ids not equal
            bool notEqualID = emp1.Id != emp2.Id;
            //print message based on result
            if (notEqualID) { Console.WriteLine("The employees have unique ID numbers."); }
            else { Console.WriteLine("The employees have the same ID number."); }
            //return bool value: true if not equal, false if equal
            return notEqualID;
        }

    }
}
