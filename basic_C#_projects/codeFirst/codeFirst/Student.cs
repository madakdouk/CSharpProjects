using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace codeFirst
{
    public class Student //student class with simple properties
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public double GPA { get; set; }

        public Student() //constructor class
        {
            GPA = 0.0; //when new student is created, GPA defaults to 0.0
        }
    }

    public class StudentContext : DbContext //for an easy way to read, save data to db
    {
        public DbSet<Student> Students { get; set; }
    }
}
