using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exception
{
    class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {

        }
    }
}
