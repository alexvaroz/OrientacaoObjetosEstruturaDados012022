using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore arvoreC = new Arvore(null, 'C', null);
            Arvore arvoreE = new Arvore(null, 'E', null);
            Arvore arvoreD = new Arvore(arvoreC, 'D', arvoreE);
            Arvore arvoreA = new Arvore(null, 'A', null);
            Arvore arvoreB = new Arvore(arvoreA, 'B', arvoreD);
            Arvore arvoreH = new Arvore(null, 'H', null);
            Arvore arvoreI = new Arvore(arvoreH, 'I', null);
            Arvore arvoreG = new Arvore(null, 'G', arvoreI);
            Arvore raiz = new Arvore(arvoreB, 'F', arvoreG);


        }
    }
}
