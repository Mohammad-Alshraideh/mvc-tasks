using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace feb_12.Models
{
    public class Course
    {
     
        public int CourseID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}