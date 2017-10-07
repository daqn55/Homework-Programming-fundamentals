using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Primes_in_Given_Range
{
    class Program
    {
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            if (startNum == 0 || startNum == 1)
            {
                startNum = 2;
            }
            for (int i = startNum; i <= endNum; i++)
            {
                int count = 0;
                int saveCurrentNum = 0;
                for (int y = 2; y <= i; y++)
                {
                    if (i % y == 0)
                    {
                        count++;
                    }
                    if (count > 2)
                    {
                        break;
                    }
                    saveCurrentNum = y;
                }
                if (count == 1)
                {
                    list.Add(saveCurrentNum);
                }
            }
            return list;
        }
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            if (endNum <= startNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                List<int> list = FindPrimesInRange(startNum, endNum);
                foreach (int prime in list)
                {
                    Console.Write(prime);
                    if (prime != list.Last())
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            } 
        }
    }
}
