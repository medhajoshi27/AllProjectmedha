using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg4
{
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(12, 13));
            Console.WriteLine(Cal.add(23, 11, 33));


        }
    }
}
