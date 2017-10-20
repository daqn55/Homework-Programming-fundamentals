using System;
using System.Linq;

namespace _04._Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x1y1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] x2y2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Point p1 = new Point() { X = x1y1[0], Y = x1y1[1] };
            Point p2 = new Point() { X = x2y2[0], Y = x2y2[1] };

            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);

            double distancePoints = Math.Sqrt(a * a + b * b);
            Console.WriteLine(distancePoints);
        }

        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
