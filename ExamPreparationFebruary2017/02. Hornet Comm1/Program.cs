using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> messages = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> broadcasts = new List<KeyValuePair<string, string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                List<string> list = input.Split(new string[] { " <-> " }, StringSplitOptions.None).ToList();
                if (list.Count == 2)
                {
                    PrivateMessages(messages, list);
                    Broadcast(broadcasts, list);
                }
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var item in messages)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
        }

        static void Broadcast(List<KeyValuePair<string, string>> broadcasts, List<string> list)
        {
            bool isAnythingButDigits = false;
            char[] tempCharToCheckHaveDigit = list[0].ToCharArray();

            for (int i = 0; i < list[0].Length; i++)
            {
                if (isAnythingButDigits)
                {
                    break;
                }
                isAnythingButDigits = char.IsDigit(tempCharToCheckHaveDigit[i]);
            }

            StringBuilder broadcastMessage = new StringBuilder();
            bool isLetter = false;
            char[] tempCharToCheckIsLetterOrDigit = list[1].ToCharArray();
            for (int i = 0; i < list[1].Length; i++)
            {
                if (char.IsLetterOrDigit(tempCharToCheckIsLetterOrDigit[i]))
                {
                    if (char.IsLower(tempCharToCheckIsLetterOrDigit[i]))
                    {
                        broadcastMessage.Append(char.ToUpper(tempCharToCheckIsLetterOrDigit[i]));
                    }
                    else if (char.IsUpper(tempCharToCheckIsLetterOrDigit[i]))
                    {
                        broadcastMessage.Append(char.ToLower(tempCharToCheckIsLetterOrDigit[i]));
                    }
                    else
                    {
                        broadcastMessage.Append(tempCharToCheckIsLetterOrDigit[i]);
                    }
                    isLetter = true;
                }
                else
                {
                    isLetter = false;
                    break;
                }
            }

            if (!isAnythingButDigits && isLetter)
            {
                broadcasts.Add(new KeyValuePair<string, string>(broadcastMessage.ToString(), list[0]));
            }

        }

        static void PrivateMessages(List<KeyValuePair<string, string>> messages, List<string> list)
        {
            bool isLetter = false;
            char[] tempToCheckIsDigitOrLetter = list[1].ToCharArray();
            for (int i = 0; i < list[1].Length; i++)
            {
                if (char.IsLetterOrDigit(tempToCheckIsDigitOrLetter[i]))
                {
                    isLetter = true;
                }
                else
                {
                    isLetter = false;
                    break;
                }
            }
            bool isDigit = false;
            char[] digitInChars = list[0].ToCharArray();
            for (int i = 0; i < list[0].Length; i++)
            {
                if (char.IsDigit(digitInChars[i]))
                {
                    isDigit = true;
                }
                else
                {
                    isDigit = false;
                    break;
                }
            }

            if (isDigit && isLetter)
            {
                StringBuilder recipient = new StringBuilder();
                Array.Reverse(digitInChars);
                for (int i = 0; i < list[0].Length; i++)
                {
                    recipient.Append(digitInChars[i]);
                }

                messages.Add(new KeyValuePair<string, string>(recipient.ToString(), list[1]));
            }
        }
    }
}
