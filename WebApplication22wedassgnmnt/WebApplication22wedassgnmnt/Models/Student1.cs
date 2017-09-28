using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication22wedassgnmnt.Models
{
    public class Student1
    {
        [Key]
        [Required]
        public int StudId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string Branch { get; set; }
    }
}