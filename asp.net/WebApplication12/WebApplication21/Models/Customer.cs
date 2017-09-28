using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication21.Models
{
    public class Customer
    { 
        [Key]
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhnNum { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public string Dropdwn { get; set; }
    }
}