using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    { 
        static void Main(string[] args)
        {
             int[] num = new int[] { 0, 4, 8, 7, 6, 9, 10, 5, 3, 22, 20, 45, 78, 71 };
             /* var numQuery =
                  from n in num
                  where (n % 2) == 0
                  select n;*/
             IEnumerable<int> numQuery = num.Where(n => n % 2 == 0).OrderBy(n1 => n1);
             foreach (int n in numQuery)
             { Console.WriteLine("even nos are:->"+ n); }
             Console.ReadLine();
            List<Program> obj = new List<Program>();
           

      }
    }
}
