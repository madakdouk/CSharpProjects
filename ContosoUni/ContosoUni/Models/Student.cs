using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUni.Models
{
    public class Student // creating class to represent student entity
    {
        public int ID { get; set; } // primary key
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //navigation prop, list that will hold all of the students enrollments
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}