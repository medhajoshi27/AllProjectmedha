using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main()
        {
            
            Box box1 = new Box(30.0f, 20.0f);
            
            IDimensions dimensions = (IDimensions)box1;

           
            System.Console.WriteLine("Length: {0}", dimensions.getLength());
            System.Console.WriteLine("Width: {0}", dimensions.getWidth());
        }
    }
}
