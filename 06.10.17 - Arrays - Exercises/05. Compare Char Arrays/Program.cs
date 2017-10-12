using System;
using System.Linq;
namespace _05._Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            string[] data2 = Console.ReadLine().Split(' ');
            char[] charArr = data.SelectMany(x => x.ToCharArray()).ToArray();
            char[] charArr2 = data2.SelectMany(x => x.ToCharArray()).ToArray();

            int sumCharArr = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                sumCharArr += charArr[i];
            }

            int sumCharArr2 = 0;
            for (int i = 0; i < charArr2.Length; i++)
            {
                sumCharArr2 += charArr2[i];
            }

            if (sumCharArr < sumCharArr2)
            {
                foreach (var item in charArr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                foreach (var item in charArr2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
            else
            {
                foreach (var item in charArr2)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
                foreach (var item in charArr)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }
        }
    }
}
