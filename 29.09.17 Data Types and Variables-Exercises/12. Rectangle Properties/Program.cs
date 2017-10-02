using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2 * (width + height);
            Console.WriteLine(perimeter);
            double area = width * height;
            Console.WriteLine(area);
            double diagonal = Math.Sqrt(width * width + height * height);
            Console.WriteLine(diagonal);
        }
    }
}
