using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication22
{
    public class Product
    {

        public int productID { get; set; }
        public string productName { get; set; }
        public int price { get; set; }

    }

    class Program
    {
        private static string p;

    public static void Main()
        {


            IList<Product> productList = new List<Product>() {
                new Product() { productID = 1, productName = "Monitor", price = 60} ,
                new Product() { productID = 2, productName = "Laptop",  price = 250} ,
                new Product() { productID = 3, productName = "Mobie",  price = 10000} ,
                new Product() { productID = 4, productName = "Mouse" , price= 5000} ,
                new Product() { productID = 5, productName = "Keyboard" ,price = 200 }
            };
            var prd = productList.Where(s => s.price > 12 && s.price < 100000);


            foreach (Product p in prd)
            {
                Console.WriteLine(p.productID + " " + p.productName + " " + p.price + " ");
            }
         
            var f = true;
            while (f)
            {
                Console.WriteLine("press 1 for new data");
                Console.WriteLine("press 2 for search");
                Console.WriteLine("press 3 for update");
                Console.WriteLine("press 4 to remove");
                Console.WriteLine("press 5 to display");
                int n;
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("enter name of product");
                        string nam = Console.ReadLine();

                        Console.WriteLine("enter id");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("enter price");
                        int price = Convert.ToInt32(Console.ReadLine());

                        productList.Add(new Product { productID = id, price = price, productName = nam });
                        Console.WriteLine($"added: id={id} name={nam} price={price}");

                        break;

                    case 2:
                        Console.WriteLine("Enter name of product");
                        string name;
                        name = Console.ReadLine();

                        var pro = productList.Where(s => s.productName == name);
                        foreach (Product pr in pro)
                        {
                            Console.Clear();
                            Console.WriteLine(pr.productID + " " + pr.productName + " " + pr.price + " ");
                        }
                        Console.ReadLine();
                        break;

                    case 3:

                        Console.WriteLine("Enter the product ID which wants to update:");
                        var update = Convert.ToInt32(Console.ReadLine());
                        var upd = productList.FirstOrDefault(u => u.productID == update);
                        Console.WriteLine("Enter new price");
                        int pri = Convert.ToInt32(Console.ReadLine());
                        upd.price = pri;
                        Console.ReadLine();
                        break;

                    case 4:

                        Console.WriteLine("Enter the product_id which wants to delete:");
                        var remove = Convert.ToInt32(Console.ReadLine());
                        var rem = productList.Where(sa => sa.productID == remove).ToList<Product>(); 
                        
                        foreach (var r in rem)
                        {
                            productList.Remove(r);
                        }

                        Console.WriteLine("Record deleted");
                        Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine("Displaying all products:");
                        foreach (var l in productList)
                        {
                            Console.WriteLine(l.productID + " " + l.productName + " " + l.price);
                        }
                        Console.ReadLine();
                        break;

                }
            }

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}




