﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaEstatica
{
    class EmptyQueueException : ApplicationException
    {
        public EmptyQueueException(string message) : base(message) { }
    }
}
