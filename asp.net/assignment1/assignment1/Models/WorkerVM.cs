using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace assignment1.Models
{
    public class WorkerVM
    {

        [Key]
        public int id { get; set; }
        public IEnumerable<State> List { get; set; }
        public IEnumerable<Country> List1 { get; set; }
        public Worker worker { get; set; }
    }
}