
using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variable 
            string menuAnswer;
            double r, l, w, h;

            //menu
            Console.WriteLine("Which type of shape will you choose: ");
            Console.WriteLine("For Circle, type 1:");
            Console.WriteLine("For Rectangle, type 2:");
            Console.WriteLine("For Cylinder, type 3:");
            menuAnswer = Console.ReadLine();

            //the case will run depending of the choice
            switch (menuAnswer)
            {
                case "1"://create circle object and calls methods to calculate area and circumference
                    Circle circle = new Circle();
                    Console.WriteLine("Enter the radius of the circle: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The circle's circumference is " + circle.Circumference(r));
                    Console.WriteLine("The circle's area is " + circle.Area(r));
                    break;
                case "2"://create rectangle object and calls methods to calculate perimenter and area
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Enter the length of the rectangle: ");
                    l = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle: ");
                    w = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The rectangle's perimeter is " + rectangle.Perimeter(l, w));
                    Console.WriteLine("The rectangle's area is " + rectangle.Area(l, w));
                    if(l == w)
                    {
                        Console.WriteLine("This rectangle is a square.");
                    }
                    break;
                case "3": //create cylinder object and calls methods to calculate the area and volume
                    Cylinder cylinder = new Cylinder();
                    Console.WriteLine("Enter the radius of the cylinder's base: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height of the cylinder: ");
                    h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The cylinder's surface area is " + cylinder.Area(h, r));
                    Console.WriteLine("The cylinder's volume is " + cylinder.Volume(h, r));
                    break;
            }
        }
    }
}
