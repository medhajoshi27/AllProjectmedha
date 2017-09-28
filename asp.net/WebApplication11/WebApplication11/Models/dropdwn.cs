using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class dropdwn
    {

        [Key]
        public int id { get; set; }
        public IEnumerable<MembershipType> List { get; set; }
        public Customer customer { get; set; }
    }
}