using System;
using System.Linq;

namespace _02._Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string nIntegers = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            string[] NumsInString = nIntegers.Split(' ');
            int[] arrNums = NumsInString.Select(int.Parse).ToArray();
            int[] sumArrNums = new int[arrNums.Length];

            for (int i = 0; i < k; i++)
            {
                int lastElem = arrNums[arrNums.Length - 1];
                for (int y = arrNums.Length-1; y > 0; y--)
                {
                    arrNums[y] = arrNums[y - 1];
                }
                arrNums[0] = lastElem;
                for (int z = 0; z < arrNums.Length; z++)
                {
                    sumArrNums[z] += arrNums[z];
                }
            }
            foreach (var item in sumArrNums)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
