using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaDinamica
{
    class Node
    {
        Object dado;
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

        public Node Elo
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
