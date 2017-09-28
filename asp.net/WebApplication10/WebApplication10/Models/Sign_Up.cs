using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class Sign_Up
    {
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set;}
        public string UserName { get; set;}
        public string Email { get; set; }
        public long Password { get; set; }
        public long ConfirmPassword { get; set; }

    }
}