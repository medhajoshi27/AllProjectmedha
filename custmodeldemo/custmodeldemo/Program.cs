using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custmodeldemo
{
    class Program
    {
        static void Main(string[] args)
        {
            medhajoshiEntities c = new medhajoshiEntities();
        c.Customer_Info.Add(new Customer_Info
            {
                Cust_Name = "Monika",
                Cust_Age = "21",
                Cust_id = "101",
                Cust_Email = "monika@exp.com",
                Cust_phone = "1236547"

            });
            c.SaveChanges();
        }
    }
}
