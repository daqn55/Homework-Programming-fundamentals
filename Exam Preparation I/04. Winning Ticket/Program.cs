using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { "," }, StringSplitOptions.None);

            string pattern = @"\${6,}|\^{6,}|#{6,}|@{6,}";
            Regex regex = new Regex(pattern);
            foreach (var t in input)
            {
                string ticket = t.Trim();
                if (ticket.Length == 20)
                {
                    string firstHalfTicket = ticket.Substring(0, 10);
                    string secondHalfTicked = ticket.Substring(10);
                    Match firstMatch = regex.Match(firstHalfTicket);
                    Match secondMatch = regex.Match(secondHalfTicked);
                    if (firstMatch.Length > 0 && secondMatch.Length > 0 && firstMatch.ToString()[0] == secondMatch.ToString()[0])
                    {
                        if (firstMatch.Length == 10 && secondMatch.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch.ToString()[0]} Jackpot!");
                        }
                        else
                        {
                            if (firstMatch.Length <= secondMatch.Length)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {firstMatch.Length}{firstMatch.ToString()[0]}");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {secondMatch.Length}{firstMatch.ToString()[0]}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
