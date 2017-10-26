using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _05._Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long isbnNumber { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("Input.txt");
            File.WriteAllText("Output.txt", "");

            int n = int.Parse(inputs[0]);

            Library library = new Library();
            library.Books = new List<Book>();
            List<string> name = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string[] bookData = inputs[i].Split();

                Book book = new Book();
                book.Title = bookData[0];
                book.Author = bookData[1];
                book.Publisher = bookData[2];
                book.ReleaseDate = DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.isbnNumber = long.Parse(bookData[4]);
                book.Price = double.Parse(bookData[5]);

                library.Books.Add(book);
                name.Add(book.Author);
            }

            List<double> sumPrice = library.Books
                .OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author)
                .GroupBy(s => s.Author)
                .Select(s => s.Sum(price => price.Price))
                .ToList();
            var nn = library.Books
                .OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author)
                .Select(x => x.Author).Distinct().ToList();



            int count = 0;
            foreach (var item in sumPrice)
            {
                File.AppendAllText("Output.txt", $"{nn[count]} -> {item:f2}\r\n");
                count++;
            }
        }
    }
}
