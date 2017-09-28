using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication22wedassgnmnt.Models
{
    public class StudDetails
    {
        [Required]
        [Key]
        public int StudId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string Gender { get; set; }
        
    }
}