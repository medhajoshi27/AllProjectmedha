using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI.Models
{
    public class Caption
    {
        public string caption { get; set; }
        public virtual Courses course { get; set; }
    }
}