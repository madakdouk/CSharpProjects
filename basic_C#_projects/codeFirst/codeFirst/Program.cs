using System.Data.Entity;

namespace codeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gray Town Middle School registration.\n");
            using (var db = new StudentContext()) //creating new db
            {
                //getting student info
                Console.WriteLine("Please enter the student's first name:");
                var nameFirst = Console.ReadLine();
                Console.WriteLine("Please enter the student's last name:");
                var nameLast = Console.ReadLine();
                Console.WriteLine("Please enter the student's date of birth in the format MM/DD/YYYY:");
                DateTime birthdate = Convert.ToDateTime(Console.ReadLine());

                var student = new Student() //creating new student object
                {
                    FirstName = nameFirst,
                    LastName = nameLast,
                    DOB = birthdate.Date
                };
                db.Students.Add(student);
                db.SaveChanges(); //adding and saving db

                Console.Read();
            }
        }
    }
}