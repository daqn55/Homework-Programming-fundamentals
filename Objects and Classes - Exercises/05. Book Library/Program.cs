using System;
using System.Collections.Generic;
using System.Globalization;
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
            int n = int.Parse(Console.ReadLine());

            Library library = new Library();
            library.Books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                string[] bookData = Console.ReadLine().Split();

                Book book = new Book();
                book.Title = bookData[0];
                book.Author = bookData[1];
                book.Publisher = bookData[2];
                book.ReleaseDate = DateTime.ParseExact(bookData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.isbnNumber = long.Parse(bookData[4]);
                book.Price = double.Parse(bookData[5]);

                library.Books.Add(book);
            }
            
            List<double> sumPrice = library.Books
                .OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author)
                .GroupBy(s => s.Author)
                .Select(s => s.Sum(price => price.Price))
                .ToList();
            var name = library.Books
                .OrderByDescending(x => x.Price)
                .ThenBy(x => x.Author)
                .Select(x =>x.Author).Distinct().ToList();



            int count = 0;
            foreach (var item in sumPrice)
            {
                Console.WriteLine($"{name[count]} -> {item:f2}");
                count++;
            }
        }
    }
}
