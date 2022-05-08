using System;
using System.Collections.Generic;
using System.Text;
using Task2.Models;
using Task2.Enums;
using Task2.Exception;
using Task2.Interfaces;

namespace Task2.Services
{
    class LibraryManager : ILibraryManager
    {
        private List<Book> _books;
        public List<Book> Books => _books;

        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void Add(Book book)
        {
            if (_books.Count > 0 && _books.Exists(a => a.Name == book.Name))
                throw new SameBookalreadyAddedExpection($"{book.Name} adli Kitab Artiq Movcuddur");

            _books.Add(book);

        }

        public List<Book> Filter(string author, Genre genre)
        {
            return _books.FindAll(a => a.Author == author || a.Genre == genre);
        }

       
    }
}
