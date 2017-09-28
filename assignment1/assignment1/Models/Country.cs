using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class Country
    {
        [Key]
        public string Country_Id { get; set; }
        public string country { get; set; }
    }
}