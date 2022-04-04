using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Humano
    {
        protected String primeiroNome;
        protected String sobreNome;       

        public Humano(string primeiroNome, string sobreNome)
        {
            this.primeiroNome = primeiroNome;
            this.sobreNome = sobreNome;
        }

        public string PrimeiroNome
        {
            get
            {
                return primeiroNome;
            }
        }

        public string SobreNome
        {
            get
            {
                return sobreNome;
            }

        }

        public String InformarNomeCompleto()
        {
            return $"{PrimeiroNome} {SobreNome}"; 
        }
    }
}
