﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class EmptyStackException : ApplicationException
    {
        public EmptyStackException(String message):base(message) { }
    }
}
