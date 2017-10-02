using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();
            bool tOrF = Convert.ToBoolean(boolean);
            if (tOrF)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
