using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FluentApi4.Models
{
    public class CustomerViewModel
    {

        [Key]
        public int id { get; set; }
        public List<Product> products { get; set; }
        public List<Order> orders { get; set; }
        public Customer customers { get; set; }

    }
}