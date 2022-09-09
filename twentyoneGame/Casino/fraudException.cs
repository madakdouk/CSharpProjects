using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class fraudException : Exception
    {
        public fraudException()
            : base() { }
        public fraudException(string message)
            : base(message) { }
    }
}
