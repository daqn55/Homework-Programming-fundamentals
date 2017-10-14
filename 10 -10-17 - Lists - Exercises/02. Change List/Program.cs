using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comand = Console.ReadLine();

            while (comand != "Odd" && comand != "Even")
            {
                var comandNum = comand.Split().ToList();

                if (comandNum[0] == "Delete")
                {
                    data.RemoveAll(x => x == int.Parse(comandNum[1]));
                }
                else if (comandNum[0] == "Insert")
                {
                    data.Insert(int.Parse(comandNum[2]), int.Parse(comandNum[1]));
                }
                comand = Console.ReadLine();
            }

            if (comand == "Odd")
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 != 0)
                    {
                        Console.Write($"{data[i]} ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i] % 2 == 0)
                    {
                        Console.Write($"{data[i]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
