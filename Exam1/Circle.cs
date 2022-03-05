
using System;
using System.Collections.Generic;
using System.Text;

//For the circle, consider providing methods to calculate circumference and the area of a circle.

namespace Exam1
{
    class Circle
    {
//formula for circumference
        public double Circumference(double radius)
        {
            double circ;
            circ = 3.14159 * 2 * radius;
            return circ;
        }
//formula for area
        public double Area(double radius)
        {
            double area;
            area = 3.14159 * (radius * radius);
            return area;
        }
    }
}
