using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PartI
{
    class BadTriangleException : Exception
    {
        public BadTriangleException() : base() 
        { }

        public BadTriangleException(string message) : base(message) 
        { } 
    }
}
