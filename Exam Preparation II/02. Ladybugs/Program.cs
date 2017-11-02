using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            long sizeOfField = int.Parse(Console.ReadLine());
            long[] indexOfBugs = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();

            long[] cells = new long[sizeOfField];
            long count = 0;

            for (int i = 0; i < cells.Length; i++)
            {
                for (int y = 0; y < indexOfBugs.Length; y++)
                {
                    if (indexOfBugs[y] >= 0 && indexOfBugs[y] < cells.Length)
                    {
                        if (i == indexOfBugs[y])
                        {
                            cells[i] = 1;
                            count++;
                            break;
                        }
                        if (count > indexOfBugs.Length)
                        {
                           break;
                        }
                    }
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] commands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                long ladybugIndex = long.Parse(commands[0]);
                string direction = commands[1];
                long flyLenght = long.Parse(commands[2]);
                long indexPlusLenght = ladybugIndex + flyLenght;
                long indexMinusLenght = ladybugIndex - flyLenght;
                bool ladyBugIndexIsValid = ladybugIndex >= 0 && ladybugIndex < cells.Length;
                if (direction == "right" && ladyBugIndexIsValid)
                {
                    if (cells[ladybugIndex] == 1)
                    {
                        cells[ladybugIndex] = 0;
                        while (true)
                        {
                            if (indexPlusLenght <= cells.Length - 1 && indexPlusLenght >= 0)
                            {
                                if (cells[indexPlusLenght] == 1)
                                {
                                    indexPlusLenght += flyLenght;
                                }
                                else
                                {
                                    cells[indexPlusLenght] = 1;
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
                else if (direction == "left" && ladyBugIndexIsValid)
                {
                    if (cells[ladybugIndex] == 1)
                    {
                        cells[ladybugIndex] = 0;
                        while (true)
                        {
                            if (indexMinusLenght >= 0 && indexMinusLenght < cells.Length)
                            {
                                if (cells[indexMinusLenght] == 1)
                                {
                                    indexMinusLenght -= flyLenght;
                                }
                                else
                                {
                                    cells[indexMinusLenght] = 1;
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                }
            }
            Console.WriteLine(string.Join(" ", cells));
        }
    }
}
