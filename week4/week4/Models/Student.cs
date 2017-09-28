using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace week4.Models
{
    public class Student
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z]+", ErrorMessage = "Please Use letters only")]
        public string Student_Name { get; set; }
        public float Student_Age { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Marital_Status { get; set; }
    }
}