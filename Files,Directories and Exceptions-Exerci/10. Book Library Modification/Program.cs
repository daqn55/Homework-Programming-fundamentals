using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _06._Book_Library_Modification
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
            }
            string dateAfter = inputs.Last();
            DateTime dateToCheck = DateTime.ParseExact(dateAfter, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            library.Books.Where(d => d.ReleaseDate > dateToCheck)
                .OrderBy(d => d.ReleaseDate)
                .ThenBy(t => t.Title)
                .ToList()
                .ForEach(p => File.AppendAllText("Output.txt", ($"{p.Title} -> {p.ReleaseDate.ToString("dd.MM.yyyy")}\r\n")));
        }
    }
}
