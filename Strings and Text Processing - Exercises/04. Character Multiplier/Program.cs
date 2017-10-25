using System;

namespace _04._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string biggerInput = "";
            string smallerInput = "";
            if (input[0].Length >= input[1].Length)
            {
                biggerInput = input[0];
                smallerInput = input[1];
            }
            else
            {
                biggerInput = input[1];
                smallerInput = input[0];
            }

            var charBigInput = biggerInput.ToCharArray();
            var charSmallInput = smallerInput.ToCharArray();
            int sum = 0;
            for (int i = 0; i < biggerInput.Length; i++)
            {
                if (i >= charSmallInput.Length)
                {
                    sum += (int)charBigInput[i];
                }
                else
                {
                    sum += (int)charBigInput[i] * (int)charSmallInput[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
