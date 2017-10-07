using System;

namespace _11._Geometry_Calculator
{
    class Program
    {
        static string CheckGeometry(string geometry)
        {
            return geometry;
        }

        static void Main(string[] args)
        {
            string geometry = Console.ReadLine();
            CheckGeometry(geometry);
            double area = 0;
            if (geometry == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = 0.5 * (side * height);
            }
            else if (geometry == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (geometry == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * (radius * radius);
            }
            Console.WriteLine($"{area:f2}");
        }
    }
}
