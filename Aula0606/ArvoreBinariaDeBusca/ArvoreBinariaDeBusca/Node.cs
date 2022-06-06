using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDeBusca
{
    class Node
    {
        int elemento;
        Node ramoDireito;
        Node ramoEsquerdo;

        public Node(int elemento)
        {
            this.elemento = elemento;
            this.ramoDireito = null;
            this.ramoEsquerdo = null;
        }

        public int Elemento
        {
            get
            {
                return elemento;
            }
        }

        internal Node RamoDireito
        {
            get
            {
                return ramoDireito;
            }
            set { ramoDireito = value; }
        }

        internal Node RamoEsquerdo
        {
            get
            {
                return ramoEsquerdo;
            }
            set { ramoEsquerdo = value; }
        }
    }
}
