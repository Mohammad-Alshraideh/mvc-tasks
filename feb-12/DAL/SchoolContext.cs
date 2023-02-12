using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using feb_12.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace feb_12.DAL
{
    public class SchoolContext : DbContext
    {
       public SchoolContext() : base("DefaultConnection")
        { 
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public  DbSet<Enrollment> Enrollments { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        
    }
  
}