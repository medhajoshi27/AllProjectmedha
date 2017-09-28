using System;
using System.ComponentModel.DataAnnotations;

namespace Student.Models
{
    public class StudentOne
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ClassName { get; set; }
        [Required]
        public DateTime DateOfAdmission { get; set; }
    }
}