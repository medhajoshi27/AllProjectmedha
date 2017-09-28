using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class Courses
    {
        public string Tag1 { get; set; }
        public int Course_Id { get; set; }
        public string Course_Name { get; set; }
        public int Author_Id { get; set; }
        public Author Author { get; set; }
        public Tag tag { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public virtual Caption caption { get; set; }
    }
}