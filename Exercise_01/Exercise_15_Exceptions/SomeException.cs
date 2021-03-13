using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_15_Exceptions
{
    public class SomeException : Exception
    {
        public SomeException(string message):base(message)
        {

        }
    }
}
