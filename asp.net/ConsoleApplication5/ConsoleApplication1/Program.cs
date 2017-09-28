using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    delegate void Del();

    class SampleClass
    {
        public void InstanceMethod()
        {
          Console.WriteLine("A message from the instance method.");
        }

        static public void StaticMethod()
        {
           Console.WriteLine("A message from the static method.");
        }
    }

    class Program
    { 
        static void Main()
        {
            SampleClass sc = new SampleClass();
            Del d = sc.InstanceMethod;
            d();
            d= SampleClass.StaticMethod;
            d();
            Console.ReadLine();
        }
    }
}
