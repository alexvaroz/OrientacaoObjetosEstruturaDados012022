using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_FilaDinamica
{
    class FilaDinamica
    {
        Node primeiroFila;
        Node ultimoFila;
        const String EMPTY_QUEUE_MESSAGE = "Pilha está vazia";

        internal Node PrimeiroFila
        {
            get
            {
                return primeiroFila;
            }
            set
            {
                primeiroFila = value;
            }
        }

        internal Node UltimoFila
        {
            get
            {
                return ultimoFila;
            }
            set
            {
                ultimoFila = value;
            }
        }

        public void Enqueue(object elemento)
        {
            Node novoNode = new Node(elemento);
            if (UltimoFila != null)
            {
                UltimoFila.Elo = novoNode;
            }
            UltimoFila = novoNode;
            if (PrimeiroFila == null)
            {
                PrimeiroFila = novoNode;
            }
        }

        public object Peek()
        {
            if (PrimeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE_MESSAGE);
            } else
            {
                return PrimeiroFila.Dado;
            }
        }

        public void Dequeue()
        {
            if (PrimeiroFila == null)
            {
                throw new EmptyQueueException(EMPTY_QUEUE_MESSAGE);
            }
            else
            {
                PrimeiroFila = PrimeiroFila.Elo;
            }
        }

        public void ShowQueueElements()
        {
            Node nodeAuxiliar = PrimeiroFila;
            while (nodeAuxiliar != null)
            {
                Console.Write($"{nodeAuxiliar.Dado} \t");
                nodeAuxiliar = nodeAuxiliar.Elo;
            } 
        }
    }
}
