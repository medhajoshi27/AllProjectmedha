using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    interface IDimensions
    {
        float getLength();
        float getWidth();
    }

    class Box : IDimensions
    {
        float lengthInches;
        float widthInches;

        Box(float length, float width)
        {
            lengthInches = length;
            widthInches = width;
        }
        // Explicit interface member implementation: 
        float IDimensions.getLength()
        {
            return lengthInches;
        }
        // Explicit interface member implementation:
        float IDimensions.getWidth()
        {
            return widthInches;
        }
    
