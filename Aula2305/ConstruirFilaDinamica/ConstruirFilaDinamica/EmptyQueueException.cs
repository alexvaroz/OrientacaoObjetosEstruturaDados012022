using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaDinamica
{
    class EmptyQueueException : ApplicationException
    {
        public EmptyQueueException(string message) : base(message) { }
    }
}
