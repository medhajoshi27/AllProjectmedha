using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication22wedassgnmnt.DTO
{
    public class StudentDto
    {
        [Required]
        [Key]
        public int StudId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int RollNo { get; set; }
        [Required]
        public string Course { get; set; }
        [Required]
        public string Branch { get; set; }
        public string Email { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}