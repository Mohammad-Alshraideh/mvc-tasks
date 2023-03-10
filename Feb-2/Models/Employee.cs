//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Feb_2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    public partial class Employee
    {
        public int id { get; set; }
        [Required]
        [StringLength(12, ErrorMessage ="Name Must from 1 to 12 characters")]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Required]
        [StringLength(12, ErrorMessage = "Last Name Must from 1 to 12 characters")]
        [Display(Name = "Last Name")]

        public string Last_name { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name = "E-mail")]

        public string E_mail { get; set; }
        [RegularExpression("((079)|(078)|(077)){1}[0-9]{7}" ,ErrorMessage ="Number must be Joirdanian")]
        public string Phone { get; set; }
        [Range(18,50)]
        public Nullable<int> Age { get; set; }
        [StringLength(12, ErrorMessage = "job title Must from 1 to 10 characters")]
        [Display(Name = "Job Title")]
        public string Job_Title { get; set; }
     
        public Nullable<bool> Gender { get; set; }
    }
}
