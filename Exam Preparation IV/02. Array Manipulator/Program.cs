using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] commands = input.Split();
                if (commands[0] == "exchange")
                {
                    exchange(commands, array);
                }
                else if (commands[0] == "max")
                {
                    int index = Max(commands, array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (commands[0] == "min")
                {
                    int index = Min(commands, array);
                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }
                else if (commands[0] == "first")
                {
                    first(commands, array);
                }
                else if (commands[0] == "last")
                {
                    last(commands, array);
                }
            }
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.WriteLine("]");
        }

        static void last(string[] commands, List<int> array)
        {
            List<int> firstNums = new List<int>();
            int numberCount = int.Parse(commands[1]);
            int count = 0;
            if (numberCount <= array.Count)
            {
                if (commands[2] == "even")
                {
                    for (int i = array.Count-1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 0)
                        {
                            count++;
                            firstNums.Add(array[i]);
                            if (count == numberCount)
                            {
                                break;
                            }
                        }
                    }
                    firstNums.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", firstNums));
                    Console.WriteLine("]");
                }
                else if (commands[2] == "odd")
                {
                    for (int i = array.Count - 1; i >= 0; i--)
                    {
                        if (array[i] % 2 == 1)
                        {
                            count++;
                            firstNums.Add(array[i]);
                            if (count == numberCount)
                            {
                                break;
                            }
                        }
                    }
                    firstNums.Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", firstNums));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        static void first(string[] commands, List<int> array)
        {
            List<int> firstNums = new List<int>();
            int numberCount = int.Parse(commands[1]);
            int count = 0;
            if (numberCount <= array.Count)
            {
                if (commands[2] == "even")
                {
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] % 2 == 0)
                        {
                            count++;
                            firstNums.Add(array[i]);
                            if (count == numberCount)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write("[");
                    Console.Write(string.Join(", ", firstNums));
                    Console.WriteLine("]");
                }
                else if (commands[2] == "odd")
                {
                    for (int i = 0; i < array.Count; i++)
                    {
                        if (array[i] % 2 == 1)
                        {
                            count++;
                            firstNums.Add(array[i]);
                            if (count == numberCount)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write("[");
                    Console.Write(string.Join(", ", firstNums));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        static int Min(string[] commands, List<int> array)
        {
            int index = -1;
            int number = 1001;
            if (commands[1] == "even")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (number >= array[i])
                        {
                            number = array[i];
                            index = i;
                        }
                    }
                }
                return index;
            }
            else if (commands[1] == "odd")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (number >= array[i])
                        {
                            number = array[i];
                            index = i;
                        }
                    }
                }
                return index;
            }
            return index;
        }

        static int Max(string[] commands, List<int> array)
        {
            int index = -1;
            int number = 0;
            if (commands[1] == "even")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (number <= array[i])
                        {
                            number = array[i];
                            index = i;
                        }
                    }
                }
                return index;
            }
            else if (commands[1] == "odd")
            {
                for (int i = 0; i < array.Count; i++)
                {
                    if (array[i] % 2 == 1)
                    {
                        if (number <= array[i])
                        {
                            number = array[i];
                            index = i;
                        }
                    }
                }
                return index;
            }
            return index;
        }

        static void exchange(string[] commands, List<int> array)
        {
            List<int> exchangeList = new List<int>();
            if (int.Parse(commands[1]) > array.Count-1 || int.Parse(commands[1]) < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                for (int i = int.Parse(commands[1]) + 1; i < array.Count; i++)
                {
                    exchangeList.Add(array[i]);
                }
                for (int i = 0; i <= int.Parse(commands[1]); i++)
                {
                    exchangeList.Add(array[i]);
                }
                array.Clear();
                array.AddRange(exchangeList);
            }
        }
    }
}
