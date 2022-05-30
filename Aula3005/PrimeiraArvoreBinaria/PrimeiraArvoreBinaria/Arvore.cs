using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraArvoreBinaria
{
    class Arvore
    {
        Arvore arvoreEsquerda;
        char dado;
        Arvore arvoreDireita;

   
        public Arvore(Arvore arvoreEsquerda, char dado, Arvore arvoreDireita)
        {
            this.arvoreEsquerda = arvoreEsquerda;
            this.dado = dado;
            this.arvoreDireita = arvoreDireita;
        }

        internal Arvore ArvoreEsquerda
        {
            get
            {
                return arvoreEsquerda;
            }

            set
            {
                arvoreEsquerda = value;
            }
        }

        public char Dado
        {
            get
            {
                return dado;
            }

            set
            {
                dado = value;
            }
        }

        internal Arvore ArvoreDireita
        {
            get
            {
                return arvoreDireita;
            }

            set
            {
                arvoreDireita = value;
            }
        }

    }
}
