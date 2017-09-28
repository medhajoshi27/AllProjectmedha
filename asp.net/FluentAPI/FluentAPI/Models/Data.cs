using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class Data
    {
        public int ID { get; set;}
        public string Name { get; set; }
        public string Email { get; set;}
        public int Address { get; set; }
        public Author author { get; set; }
        public Courses course { get; set; }
    }
}