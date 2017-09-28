using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            medhajoshiEntities pro = new medhajoshiEntities();
       /*    pro.Products.Add(new Product
            {
                ID = 106,
                Name = "pastry",
                Price = 30,
                Qty = 4,
                Category ="Food"
            });
          pro.Products.Add(new Product
              {
                  ID = 102,
                  Name = "noodles",
                  Price = 100,
                  Qty = 10,
                  Category = "Chinese"
              });
              pro.Products.Add(new Product
              {
                  ID = 103,
                  Name = "Apple",
                  Price = 120,
                  Qty = 30,
                  Category = "Fruit"
              });
              pro.Products.Add(new Product
              {
                  ID = 104,
                  Name = "Coffee",
                  Price = 90,
                  Qty = 2,
                  Category = "Beverage"
              });*/
            pro.SaveChanges();
              var p = new medhajoshiEntities();
              var rem = p.Products.SingleOrDefault(m => m.ID == 101);
              if(rem!=null)
              { p.Products.Remove(rem);
                  p.SaveChanges();
              }
            pro.SaveChanges();
            var u = new medhajoshiEntities();
            Console.WriteLine("enter the Id you want to update");
            var update = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the updated price");
            var upd = Convert.ToInt32(Console.ReadLine());
            Product updt = u.Products.FirstOrDefault(m => m.ID == update);
            updt.Price = upd;
            u.SaveChanges();
        }
    }
}
