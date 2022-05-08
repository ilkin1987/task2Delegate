using System;
using System.Collections.Generic;
using System.Text;
using Task2.Enums;
using Task2.Models;
using Task2.Interfaces;
using Task2.Exception;


namespace Task2.Interfaces
{
    interface ILibraryManager
    {
        List<Book> Books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(string search);
        List<Book> Filter(string author, Genre genre);
    }
}
