using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_FilaDinamica
{
    class Node
    {
        object dado;
        Node elo;

        public Node(object dado)
        {
            this.dado = dado;
            this.elo = null;
        }

        public object Dado
        {
            get
            {
                return dado;
            }
        }

        internal Node Elo
        {
            get
            {
                return elo;
            }
            set
            {
                elo = value;
            }
        }
    }
}
