using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jqgrid.Models
{
    public class Order
    {
        public string Quantity { get; set; }
        public int Price { get; set; }
        public string Order_id { get; set; }
        public string Customer_ID { get; set; }
        public Customer customer { get; set; }
        public Product product { get; set; }
        public ICollection<Product> products { get; set; }
    }
}