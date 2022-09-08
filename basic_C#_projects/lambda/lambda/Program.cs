using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda
{
    internal class Program
    {
        static void Main()
        {
            List<employee> employees = new List<employee>(); //creating new list

            employees.AddRange(new List<employee> //adding employees to list
            {
                new employee { id = 1, firstName = "Joe", lastName = "One" },
                new employee { id = 2, firstName = "Joe", lastName = "Two"},
                new employee { id = 3, firstName = "Fernando", lastName = "X"},
                new employee { id = 4, firstName = "Noah", lastName = "Y"},
                new employee { id = 5, firstName = "Addie", lastName = "Z"},
                new employee { id = 6, firstName = "Jacob", lastName = "A"},
                new employee { id = 7, firstName = "Taylor", lastName = "B"},
                new employee { id = 8, firstName = "Nick", lastName = "C"},
                new employee { id = 9, firstName = "Arjun", lastName = "D"},
                new employee { id = 10, firstName = "Maher", lastName = "E"}
            });

            List<employee> joes = new List<employee>(); //creating another new list

            foreach (employee employee in employees) //using foreach loop to add employees named joe to new list
            {
                if (employee.firstName == "Joe") //when first name is joe employee will be added to the new list
                {
                    joes.Add(employee);
                }
            }
            
            //using lambda expression to complete same task with less code
            List<employee> joes2 = employees.Where(x => x.firstName == "Joe").ToList();

            List<employee> idFive = employees.Where(x => x.id > 5).ToList(); //new list of employees who have ids more than 5
        }
    }
}
