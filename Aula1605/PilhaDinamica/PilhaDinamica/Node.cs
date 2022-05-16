using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class Node
    {
        int dado;
        Node elo;

        public Node(int dado)
        {
            this.dado = dado;
            this.elo = null;
        }

        public int Dado
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
