using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    // interface IDimensions
    //  {
    //    float getLength();
    //  float getWidth();
    // }

    // class Box : IDimensions
    //{
    //  float lengthInches;
    //float widthInches;

    //Box(float length, float width)
    //{
    //  lengthInches = length;
    // widthInches = width;
    //}

    //float IDimensions.getLength()
    //{
    //  return lengthInches;
    //}

    //  float IDimensions.getWidth()
    // {
    //   return widthInches;
    //}
    class Class3
    { static void Main()
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }

            //  Box box1 = new Box(30.0f, 20.0f);

            //IDimensions dimensions = (IDimensions)box1;

            //System.Console.WriteLine("Length: {0}", dimensions.getLength());
            //System.Console.WriteLine("Width: {0}", dimensions.getWidth());
            Console.ReadLine();
        }
    }
}
