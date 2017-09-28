using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Shape
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter a number");
            i = int.Parse(Console.ReadLine());
            if(i%2==0)
            {
                Console.Write("Entered number is even number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered number is Odd");
                Console.Read();
            }
        }
    }
}
