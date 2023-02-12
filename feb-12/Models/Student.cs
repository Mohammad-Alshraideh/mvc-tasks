using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace feb_12.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    
        public DateTime EntrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public Student()
        {
            this.EntrollmentDate = DateTime.Now;
        
        }
    }
}