using System.Collections.Generic;

namespace FluentApi4.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<Product> Product { get; set; }
    }
}