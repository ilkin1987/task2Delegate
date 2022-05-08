using System;
using Task2.Enums;
using Task2.Models;
using Task2.Services;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Basic English", "Eric H.Glendinning", 136, Genre.Computing);
            Book book2 = new Book("Ana", "Huseyn Cavid", 350, Genre.Drama);
            Book book3 = new Book("Leyli ve Mecnun", "Nizami Gencevi", 400, Genre.Poema);
            Book book4 = new Book("Dream Town", "David Baldacci", 432, Genre.Thriller);
           
            LibraryManager librarymanager = new LibraryManager();

            librarymanager.Add(book1);
            librarymanager.Add(book2);
            librarymanager.Add(book3);
            librarymanager.Add(book4);
            

            foreach (Book book in librarymanager.Search("m"))
            {
                Console.WriteLine(book);
            }
        }
    }
}

