﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double heigth = double.Parse(Console.ReadLine());
            double volume = (lenght + width + heigth) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
