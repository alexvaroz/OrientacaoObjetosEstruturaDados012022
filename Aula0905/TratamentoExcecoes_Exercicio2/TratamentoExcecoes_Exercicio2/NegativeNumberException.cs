using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes_Exercicio2
{
    class NegativeNumberException : ApplicationException
    {
        public NegativeNumberException(string mensagem) : base(mensagem) { }
    }
}
