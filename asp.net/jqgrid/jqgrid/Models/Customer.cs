using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqgrid.Models
{
    public class Customer
    {
        public string Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}