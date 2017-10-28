using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<string, Dictionary<string, int>> multyDict = new SortedDictionary<string, Dictionary<string, int>>();
            while (input != "end" && input != "End" && input != "END")
            {
                string[] splitInput = input.Split(new char[] {'=', ' '});
                if (splitInput.Length == 6)
                {
                    if (multyDict.Keys.Contains(splitInput[5]) && multyDict[splitInput[5]].Keys.Contains(splitInput[1]))
                    {
                        multyDict[splitInput[5]][splitInput[1]]++;
                    }
                    else
                    {
                        Dictionary<string, int> insaitDict = new Dictionary<string, int>();
                        if (multyDict.Keys.Contains(splitInput[5]))
                        {
                            multyDict[splitInput[5]].Add(splitInput[1], 1);
                        }
                        else
                        {
                            insaitDict.Add(splitInput[1], 1);
                            multyDict.Add(splitInput[5], insaitDict);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var item in multyDict)
            {
                int count = 0;
                Console.WriteLine(item.Key + ": ");
                foreach (var ip in item.Value)
                {
                    if (item.Value.Count-1 == count)
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ".");
                    }
                    else
                    {
                        Console.Write(ip.Key + " => " + ip.Value + ", ");
                    }
                    count++;
                }
                Console.WriteLine();
            }

        }
    }
}
