
using System;
using System.Collections.Generic;
using System.Text;

//For the rectangle, consider providing behaviors to calculate area, perimeter and the polygon diagonals.

namespace Exam1
{
    class Rectangle
    {
// formula for perimenter
        public double Perimeter(double length, double width)
        {
            double peri;
            peri = 2 *(width = length);
            return peri;
        }
//formula for area
        public double Area(double length, double width)
        {
            double area;
            area = length * width;
            return area;
        }
    }
}
