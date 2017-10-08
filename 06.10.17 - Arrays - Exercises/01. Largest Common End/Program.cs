using System;

namespace _01._Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            string words2 = Console.ReadLine();

            string[] arr1 = words.Split(' ');
            string[] arr2 = words2.Split(' ');
            if (arr1.Length < arr2.Length)
            {
                string[] memoryArr = arr1;
                arr1 = arr2;
                arr2 = memoryArr;
            }

            int countBeginig = 0;
            int countEnd = 0;
            for (long i = 0; i < arr1.Length; i++)
            {
                if (arr2.Length-1 < i)
                {
                    break;
                }
                if (arr1[i] == arr2[i])
                {
                    countBeginig++;
                }
                else
                {
                    break;
                }
            }
            int lengthArr2 = arr2.Length - 1;
            for (long i = arr1.Length - 1; i >= 0; i--)
            { 
                if (arr2[lengthArr2] == arr1[i])
                {
                    countEnd++;
                }
                if (lengthArr2 > 0)
                {
                    lengthArr2--;
                }
                else
                {
                    break;
                }
            }
            if (countBeginig > countEnd)
            {
                Console.WriteLine(countBeginig);
            }
            else
            {
                Console.WriteLine(countEnd);
            }
        }
    }
}
