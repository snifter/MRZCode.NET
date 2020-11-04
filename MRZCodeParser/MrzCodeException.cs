using System;

namespace MRZCodeParser
{
    public class MrzCodeException : Exception
    {
        internal MrzCodeException(string message) : base(message)
        {
        }
    }
}