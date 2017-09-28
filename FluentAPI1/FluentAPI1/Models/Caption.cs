using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FluentAPI1.Models
{
    public class Caption
    {
        public string caption { get; set; }
        public virtual Course course { get; set; }
    }
}