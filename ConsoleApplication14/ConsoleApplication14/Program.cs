using System;
using System.Linq;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            medhajoshiEntities mj = new medhajoshiEntities();
            /* mj.customs.Add(new custom
             {
                 Name = "rachel",
                 Age = 10,
                 Email = "rachel@gmail.com",
                 ID = 109,
                 Phone_no = 415262
             });
             mj.customs.Add(new custom
             {
                 Name = "monika",
                 Age = 20,
                 Email = "monika@gmail.com",
                 ID = 110,
                 Phone_no = 41748562
             });
             mj.customs.Add(new custom
             {
                 Name = "joey",
                 Age = 20,
                 Email = "joey@gmail.com",
                 ID = 108,
                 Phone_no = 7846262
             });
             mj.customs.Add(new custom
             {
                 Name = "bob",
                 Age = 10,
                 Email = "bob@gmail.com",
                 ID = 107,
                 Phone_no = 415262
             });
          mj.SaveChanges();
             //remove
               var c1 = new medhajoshiEntities();

                var itemToRemove = c1.customs.SingleOrDefault(x => x.ID == 105);

             if (itemToRemove != null)
             {
                 c1.customs.Remove(itemToRemove);
                 c1.SaveChanges();
             }

             var c2 = new medhajoshiEntities();
              Console.WriteLine("Enter the ID which wants to update:");
              int update = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter the new Phone no");
              int phn = Convert.ToInt32(Console.ReadLine());
              custom s =c2.customs.FirstOrDefault(u => u.ID == update);
              s.Phone_no = phn;
              c2.SaveChanges();*/

            medhajoshiEntities em = new medhajoshiEntities();
             em.depts.Add(new dept
             {
                 dept_name = "HR",
                 dept_id = 1,
                 ID = 105
             });
            em.depts.Add(new dept
            {
                dept_name = "IS",
                dept_id = 2,
                ID = 109
            });
            em.depts.Add(new dept
            {
                dept_name = "Operation",
                dept_id = 3,
                ID = 107
            });
            em.depts.Add(new dept
            {
                dept_name = "ITS",
                dept_id = 4,
                ID = 108
            });
            em.depts.Add(new dept
            {
                dept_name = "Mean",
                dept_id = 5,
                ID = 110
            });
            em.SaveChanges();
        }
    }
}
