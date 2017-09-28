using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class newClass
    {
        
        public string Name { get; set; }
        [Key]
        public string email { get; set; }
    }
}