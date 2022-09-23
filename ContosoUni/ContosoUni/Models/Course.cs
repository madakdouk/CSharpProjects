using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUni.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // allows you to enter primary key instead of db generating one
        public int CourseID { get; set; } // primary key
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; } // course entity can be associated with multiple enrollments
    }
}