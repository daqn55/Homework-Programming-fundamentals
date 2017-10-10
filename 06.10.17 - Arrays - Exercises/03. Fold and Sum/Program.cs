using System;
using System.Linq;

namespace _03._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int dataSmallLength = (data.Length / 2) / 2;
            int[] dataBegining = new int[dataSmallLength];
            for (int i = 0; i < dataSmallLength; i++)
            {
                dataBegining[i] = data[i];
            }
            Array.Reverse(dataBegining);
            int count = 0;
            int[] dataEnd = new int[dataSmallLength];
            for (int i = data.Length-1; i >= data.Length / 2 + dataSmallLength; i--)
            {
                dataEnd[dataEnd.Length-1 - count] = data[i];
                count++;
            }
            Array.Reverse(dataEnd);
            int countMiddle = 0;
            int[] dataMiddle = new int[data.Length / 2];
            for (int i = dataSmallLength; i < data.Length - dataSmallLength; i++)
            {
                dataMiddle[countMiddle] = data[i];
                countMiddle++;
            }

            int countSum = 0;
            for (int i = 0; i < dataMiddle.Length; i++)
            {
                if (i < dataSmallLength)
                {
                    dataMiddle[i] += dataBegining[i];
                }
                else
                {
                    dataMiddle[i] += dataEnd[countSum];
                    countSum++;
                }
            }
            
            foreach (var item in dataMiddle)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
