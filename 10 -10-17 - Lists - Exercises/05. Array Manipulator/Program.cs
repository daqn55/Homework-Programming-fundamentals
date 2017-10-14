using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> data = Console.ReadLine().Split().Select(int.Parse).ToList();

            string comand = Console.ReadLine();


            while (comand != "print")
            {
                List<string> comandNums = comand.Split().ToList();

                if (comandNums[0] == "add")
                {
                    data.Insert(int.Parse(comandNums[1]), int.Parse(comandNums[2]));
                }
                else if (comandNums[0] == "addMany")
                {
                    List<int> tempColection = new List<int>();
                    for (int i = 2; i < comandNums.Count; i++)
                    {
                        tempColection.Add(int.Parse(comandNums[i]));
                    }
                    data.InsertRange(int.Parse(comandNums[1]), tempColection);
                }
                else if (comandNums[0] == "contains")
                {
                    if (data.Contains(int.Parse(comandNums[1])))
                    {
                        int count = 0;
                        for (int i = 0; i < data.Count; i++)
                        {
                            if (int.Parse(comandNums[1]) == data[i])
                            {
                                break;
                            }
                            count++;
                        }
                        Console.WriteLine(count);
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (comandNums[0] == "remove")
                {
                    data.RemoveAt(int.Parse(comandNums[1]));
                }
                else if (comandNums[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(comandNums[1]); i++)
                    {
                        int temp = data[0];
                        for (int y = 1; y < data.Count; y++)
                        {
                            data[y - 1] = data[y];
                            if (y == data.Count - 1)
                            {
                                data[data.Count - 1] = temp;
                            }
                        }
                    }
                }
                else if (comandNums[0] == "sumPairs")
                {
                    List<int> newData = new List<int>();
                    if (data.Count % 2 == 0)
                    {
                        for (int i = 1; i < data.Count; i+=2)
                        {
                            newData.Add(data[i - 1] + data[i]);
                        }
                    }
                    else
                    {
                        for (int i = 1; i < data.Count-1; i += 2)
                        {
                            newData.Add(data[i - 1] + data[i]);
                        }
                        newData.Add(data[data.Count - 1]);
                    }
                    data.Clear();
                    data.AddRange(newData);
                }

                comand = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", data));
            Console.WriteLine("]");
        }
    }
}
