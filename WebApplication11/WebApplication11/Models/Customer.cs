using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        // [Display(Name = "Membership Type")]
        //  public byte MembershipId { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public string Memebers { get; set; }
    }
}