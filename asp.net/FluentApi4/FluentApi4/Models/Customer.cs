using System.Collections.Generic;

namespace FluentApi4.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public virtual List<Order> Order{ get; set; }
    }
}