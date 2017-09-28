using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication20.Models;

namespace WebApplication20.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "CPU", Category = "Hardware", Price = 10000 },
            new Product { Id = 2, Name = "Laptop", Category = "Gadgets", Price = 36000 },
            new Product { Id = 3, Name = "Keyboard", Category = "Hardware", Price = 5000 }
       };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
