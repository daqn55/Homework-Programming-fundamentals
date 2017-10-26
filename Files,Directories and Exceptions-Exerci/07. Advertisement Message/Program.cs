using System;
using System.IO;

namespace _02._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            foreach (var item in inputs)
            {
                string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
                string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
                string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
                string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

                Random rnd = new Random();
                for (int i = 0; i <int.Parse(item); i++)
                {
                    int randomPhrases = rnd.Next(phrases.Length);
                    int randomEvent = rnd.Next(events.Length);
                    int randomAuthors = rnd.Next(authors.Length);
                    int randomCities = rnd.Next(cities.Length);

                    File.AppendAllText("Output.txt", $"{phrases[randomPhrases]} {events[randomEvent]} " +
                        $"{authors[randomAuthors]} - {cities[randomCities]}.\r\n");
                }
            }
            

        }
    }
}