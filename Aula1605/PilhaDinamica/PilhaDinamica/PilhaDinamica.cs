using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    class PilhaDinamica
    {
        Node topo;

        public PilhaDinamica()
        {
            this.topo = null;
        }

        public Node Topo
        {
            get
            {
                return topo;
            }
        }

        public void Push(int elemento)
        {
            Node node = new Node(elemento);
            node.Elo = topo;
            topo = node;
        }
    }
}
