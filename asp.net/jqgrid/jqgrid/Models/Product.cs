using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqgrid.Models
{
    public class Product
    {
        public string Product_Id { get; set; }
        public string Product_Name { get; set; }
        public Order order { get; set; }
        public ICollection<Order> orders { get; set; }
    }
}