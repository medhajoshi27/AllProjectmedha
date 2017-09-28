using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI1.Models
{
    public class Tag
    {
        public string Tag1 { get; set; }
        public ICollection<Course> Course { get; set; }
        public Course course { get; set; }
    }
}