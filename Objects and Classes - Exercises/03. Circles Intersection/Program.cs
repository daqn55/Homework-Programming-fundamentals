using System;
using System.Linq;

namespace _03._Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x1y1r1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] x2y2r2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point p1 = new Point() { X = x1y1r1[0], Y = x1y1r1[1] };
            Point p2 = new Point() { X = x2y2r2[0], Y = x2y2r2[1] };
            Circle r1 = new Circle() { R = x1y1r1[2] };
            Circle r2 = new Circle() { R = x2y2r2[2] };
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            double d = Math.Sqrt(a * a + b * b);
            if (d <= r1.R + r2.R)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }

    class Circle
    {
        public double R { get; set; }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
