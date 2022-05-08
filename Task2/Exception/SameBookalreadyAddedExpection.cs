using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Exception
{
    class SameBookalreadyAddedExpection : Exception
    {
        public SameBookalreadyAddedExpection(string message) : base(message)
        {

        }
    }
}
