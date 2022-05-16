using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class FullStackException : ApplicationException
    {
        public FullStackException(string message) : base(message) {}
    }
}
