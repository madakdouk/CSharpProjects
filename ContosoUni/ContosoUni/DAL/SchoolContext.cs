using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContosoUni.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUni.DAL
{
    public class SchoolContext : DbContext // inheriting from DbContext class, part of Entity Framework
    {
        public SchoolContext() : base("SchoolContext") // passing db connection string into constructor
        {
        }

        /******************
         DbSet is made for each entity set 
         entity set corresponds to db table, whereas entity corresponds to row in table

         DbSet for enrollment and course can technically be omitted, because both entities
         are referenced in student entity
        ******************/
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) // this method builds db
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); // prevents table names being plural
                                                                               // can be removed if plural is preferred
        }
    }
}