using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reactivo3.Exceptions
{
    class NameException : Exception
    {
        public NameException(string message) : base(message)
        {

        }
    }
}
