using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment.Models
{
    public class Worker
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z]+", ErrorMessage = "Please Use letters only")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }
        public string Country{ get; set; }
        public string State { get; set; }
        public string Address { get; set; }
    }
}