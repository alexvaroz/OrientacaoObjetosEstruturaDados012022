using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaDinamica
{
    class MinhaFila
    {
        const string EMPTY_QUEUE = "A fila já está vazia";
        Node primeiroFila;
        Node ultimoFila;

        public Node PrimeiroFila
        {
            get
            {
                return primeiroFila;
            }
        }

        public Node UltimoFila
        {
            get
            {
                return ultimoFila;
            }
        }

        public void Enqueue(object elemento)
        {
            Node novoNode = new Node(elemento);
            if (ultimoFila != null)
            {
                ultimoFila.Elo = novoNode; 
            }
            ultimoFila = novoNode;
            if (primeiroFila == null)
            {
                primeiroFila = novoNode;
            } 
        }

        public void Dequeue()
        {
            if (primeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            } else
            {
                Node nodeAuxiliar = primeiroFila.Elo;
                primeiroFila = nodeAuxiliar;
            }
        }

        public object Peek()
        {
            if (primeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
            else
            {
                return primeiroFila.Dado;
            }
        }

    }
}
