using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercorrimentoArvoreBinaria
{
    class Node
    {
        char elemento;
        Node ramoEsquerdo;
        Node ramoDireito;

        public Node(char elemento, Node ramoEsquerdo, Node ramoDireito)
        {
            this.elemento = elemento;
            this.ramoEsquerdo = ramoEsquerdo;
            this.ramoDireito = ramoDireito;
        }

        public Node(char elemento)
        {
            this.elemento = elemento;
            this.ramoEsquerdo = null;
            this.ramoDireito = null;
        }

        public char Elemento
        {
            get
            {
                return elemento;
            }
        }

        internal Node RamoEsquerdo
        {
            get
            {
                return ramoEsquerdo;
            }
        }

        internal Node RamoDireito
        {
            get
            {
                return ramoDireito;
            }
        }

 
    }
}
