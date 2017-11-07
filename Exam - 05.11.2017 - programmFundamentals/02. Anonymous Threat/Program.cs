using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "3:1")
                {
                    break;
                }
                string[] commands = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "merge")
                {
                    Merge(commands, data);
                }
                if (commands[0] == "divide")
                {
                    Divide(commands, data);
                }

            }
            Console.WriteLine(string.Join(" ", data));
        }

        static void Divide(string[] commands, List<string> data)
        {
            List<string> tempListData = new List<string>();
            int index = int.Parse(commands[1]);
            int partitions = int.Parse(commands[2]);
            string tempDivideData = "";

            int divide = data[index].Length / partitions;
            int divide1 = data[index].Length / partitions;
            int count = 0;
            int count2 = 0;
            for (int i = 0; i < data[index].Length; i += divide1)
            {
                count2++;
                count = i;
                if (count2 == partitions)
                {
                    break;
                }
                tempDivideData = "";
                for (int y = i; y < divide; y++)
                {
                    tempDivideData += data[index][y];
                }
                tempListData.Add(tempDivideData);
                divide += divide1;
            }
            tempDivideData = "";

            for (int i = count; i < data[index].Length; i++)
            {
                tempDivideData += data[index][i];
            }
            tempListData.Add(tempDivideData);

            data.RemoveAt(index);
            data.InsertRange(index, tempListData);

        }

        static void Merge(string[] commands, List<string> data)
        {
            List<string> tempListData = new List<string>();
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            string tempMergeData = "";

            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if (startIndex > data.Count - 1)
            {
                startIndex = data.Count - 1;
            }
            if (endIndex < 0)
            {
                endIndex = 0;
            }
            else if (endIndex > data.Count - 1)
            {
                endIndex = data.Count - 1;
            }

            for (int i = 0; i < data.Count; i++)
            {
                if (i >= startIndex && i <= endIndex)
                {
                    tempMergeData += data[i];
                    data[i] = "";
                }
            }
            data[endIndex] = tempMergeData;
            foreach (var item in data)
            {
                if (item != "")
                {
                    tempListData.Add(item);
                }
            }
            data.Clear();
            data.AddRange(tempListData);
        }
    }
}
