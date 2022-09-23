using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUni.Models
{
    public enum Grade //this data type can ONLY be set to one of the following values
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; } // primary keey
        public int CourseID { get; set; } // foreign key
        public int StudentID { get; set; } // foreign key
        public Grade? Grade { get; set; } // ? allows the data to be null in case grade hasn't been assigned yet

        /*****************************************
         enrollment entity only associates with one course entity and one student entity
         unlike student entity being able to associate with 2+ enrollments
         therefor, list type is not required here
        ******************************************/
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}