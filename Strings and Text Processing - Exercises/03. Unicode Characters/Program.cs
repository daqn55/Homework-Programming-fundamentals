using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder unicode = new StringBuilder();
            foreach (var ch in input)
            {
                unicode.Append("\\u");
                unicode.Append(string.Format("{0:x4}", (int)ch));
            }
            Console.WriteLine(unicode.ToString());
        }
    }
}
