using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{ 
    class Estudante:Humano
    {
        public int notaFinal;

        public Estudante(string primeiroNome, 
            string ultimoNome, int notaFinal):base(primeiroNome, ultimoNome)
        {
            this.notaFinal = notaFinal;
        }
    }
}
