﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  string Position { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public int Salary { get; set; }
    }
}