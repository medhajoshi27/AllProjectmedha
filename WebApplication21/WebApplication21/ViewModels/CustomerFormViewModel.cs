using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication21.Models;

namespace WebApplication21.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}