using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        public delegate void Del(string message);
        public static void DelegMethd(string message)
        {
            Console.WriteLine("A new Delegate Example");
        }
        public  void callBckExp(int no1, int no2 , Del callback)
        {
            callback("The number is: " + (no1 + no2).ToString());
        }
        static void Main(string[] args)
        {
           Del t = DelegMethd;
           
            t("Hello World");
          
           
            Console.ReadLine();
        }
    }
}
