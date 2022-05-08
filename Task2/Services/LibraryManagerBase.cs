namespace Task2.Services
{
    internal class LibraryManagerBase
    {

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(b => b.Name == name);

            if (book != null)
            {
                return book;
            }


        }
    }
}