using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sumRemovetElemets = 0;
            while (input.Any())
            {
                int index = int.Parse(Console.ReadLine());
                int saveNumToRemove = 0;
                if (index > input.Count-1)
                {
                    saveNumToRemove = input.Last();
                    input[input.Count - 1] = input.First();
                    sumRemovetElemets += saveNumToRemove;
                }
                else if (index < 0)
                {
                    saveNumToRemove = input.First();
                    input[0] = input.Last();
                    sumRemovetElemets += saveNumToRemove;
                }
                else
                {
                    saveNumToRemove = input[index];
                    input.RemoveAt(index);
                    sumRemovetElemets += saveNumToRemove;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= saveNumToRemove)
                    {
                        input[i] += saveNumToRemove;
                    }
                    else
                    {
                        input[i] -= saveNumToRemove;
                    }
                }
            }
            Console.WriteLine(sumRemovetElemets);
        }
    }
}
