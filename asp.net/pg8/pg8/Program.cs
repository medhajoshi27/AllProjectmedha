using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg8
{
    public class ConstTest
    {
        class SampleClass
        {
            public int x;
            public int y;
            public const int c1 = 5;
            public const int c2 = c1 + 5;

            public SampleClass(int p1, int p2)
            {
                x = p1;
                y = p2;
            }
        }
            static void Main(String[] arg)
            {
                SampleClass sc = new SampleClass(11, 22);
                Console.WriteLine("x={0},y={1}", sc.x, sc.y);
                Console.WriteLine("c1= {0} , c2= {1}", SampleClass.c1, SampleClass.c2);

            }
        }
    }

