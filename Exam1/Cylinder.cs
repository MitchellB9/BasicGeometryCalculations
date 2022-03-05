
using System;
using System.Collections.Generic;
using System.Text;

//For the cylinder, consider providing behaviors to calculate the volume and surface area for a closed cylinder.

namespace Exam1
{
    class Cylinder
    {
// formula for area and volume
        public double Area(double height, double radius)
        {
            double area;
            area = (2 * 3.14159 * radius * height) + (2 * 3.14159 * (radius * radius));
            return area;
        }

        public double Volume(double height, double radius)
        {
            double vol;
            vol = 3.14159 * height * (radius * radius);
            return vol;
        }

    }
}
