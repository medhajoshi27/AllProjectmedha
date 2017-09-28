using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.Write("enter a number:");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.Write("Reverse of a number is:" + reverse);
            Console.Read();                        
        }
    }
}
