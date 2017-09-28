using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class Author
    {
        public int Author_Id { get; set; }
        public string Author_Name { get; set; }
        public string Description { get; set; }
        public ICollection<Courses> Course { get; set; }

    }
}