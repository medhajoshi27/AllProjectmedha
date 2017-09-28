using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rectangle
    {

        double width;
        double length;
        public void Acceptdetails()
        {
            width = 22.5;
            length = 33.4;
        }
        public double GetArea()
        {
            return width * length;
        }
        public void Display()
        {
            Console.WriteLine("length:{0}", length);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
