using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class Tag
    {
       
        public string Tag1 { get; set; }
        public ICollection<Courses> Course { get; set; }
        public Courses course { get; set; }
    }
}