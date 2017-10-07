using System;
using System.Linq;

namespace _12._Master_Number
{
    class Program
    {
        static bool IsPalindrome(int num)
        {
            int newNum = num;
            int result = 0;
            while (newNum > 0)
            {
                result = result * 10 + newNum % 10;
                newNum /= 10;
            }
            if (num == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            for (int i = num; i > 10; i--)
            {
                sum = sum + (num % 10);
                num = num / 10;
                if (num == 0)
                {
                    break;
                }
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            for (int i = num; i > 10; i--)
            {
                int evenNum = 0;
                evenNum += (num % 10);
                if (evenNum % 2 == 0)
                {
                    return true;
                }
                num = num / 10;
                if (num == 0)
                {
                    break;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) &&
                    ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
