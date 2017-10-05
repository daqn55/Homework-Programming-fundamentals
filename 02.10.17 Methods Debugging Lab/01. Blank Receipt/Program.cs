using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void ReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        static void ReceiptBody()
        {
            Console.Write("Charged to");
            Console.WriteLine(new string('_', 20));
            Console.Write("Received by");
            Console.WriteLine(new string('_', 19));
        }
        static void ReceiptTotal()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            ReceiptHeader();
            ReceiptBody();
            ReceiptTotal();
        }
    }
}
