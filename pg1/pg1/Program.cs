using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg1
{
    class Addition
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.Write("Enter a number:");
            num=int.Parse(Console.ReadLine());
            while(num!=0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.Write("\n Sum of digits of number:" + sum);
            Console.ReadLine();
        }

    }
}
