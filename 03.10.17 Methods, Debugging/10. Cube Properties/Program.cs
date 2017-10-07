using System;

namespace _10._Cube_Properties
{
    class Program
    {
        static double CubeFaceLenght(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            return face;
        }

        static double CubeSpaceLenght(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            return space;
        }

        static double CubeVolumeLenght(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        static double CubeAreaLenght(double side)
        {
            double area = 6 * (side * side);
            return area;
        }

        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            if (parameter == "face")
            {
                Console.WriteLine($"{CubeFaceLenght(side):f2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{CubeSpaceLenght(side):f2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{CubeVolumeLenght(side):f2}");
            }
            else
            {
                Console.WriteLine($"{CubeAreaLenght(side):f2}");
            }
        }
    }
}
