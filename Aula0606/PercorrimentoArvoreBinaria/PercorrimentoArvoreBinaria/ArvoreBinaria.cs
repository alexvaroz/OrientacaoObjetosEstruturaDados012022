using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercorrimentoArvoreBinaria
{
    class ArvoreBinaria
    {
        Node raiz;

        public ArvoreBinaria(Node raiz)
        {
            this.raiz = raiz;
        }

        internal Node Raiz
        {
            get
            {
                return raiz;
            }
        }
    }
}
