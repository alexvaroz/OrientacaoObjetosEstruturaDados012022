using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaEstatica
{
    class FilaEstatica
    {
        const String FULL_QUEUE = "A fila já está cheia";
        const String EMPTY_QUEUE = "A fila já está vazia";
        int primeiroDaFila;
        int ultimoDaFila;
        int[] elementos;

        public FilaEstatica(int qtdeElementos)
        {
            this.primeiroDaFila = 0;
            this.ultimoDaFila = -1;
            this.elementos = new int[qtdeElementos];
        }

        public int PrimeiroDaFila
        {
            get
            {
                return primeiroDaFila;
            }

            set
            {
                primeiroDaFila = value;
            }
        }

        public int UltimoDaFila
        {
            get
            {
                return ultimoDaFila;
            }

            set
            {
                ultimoDaFila = value;
            }
        }

        public int[] Elementos
        {
            get
            {
                return elementos;
            }
        }

        public void Enqueue(int elemento)
        {
            if (ultimoDaFila < elementos.Length - 1)
            {
                ultimoDaFila++;
                elementos[ultimoDaFila] = elemento;
            } else
            {
                throw new FullQueueException(FULL_QUEUE);
            }
        }

        public void Dequeue()
        {
            if (ultimoDaFila > -1)
            {
                primeiroDaFila++;
                if (primeiroDaFila > ultimoDaFila)
                {
                    primeiroDaFila = 0;
                    ultimoDaFila = -1;
                }
            } else
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            }
        }

        public int Peek()
        {
            if (ultimoDaFila == -1)
            {
                throw new EmptyQueueException(EMPTY_QUEUE);
            } else
            {
                return elementos[primeiroDaFila];
            }
        }

        public int Count()
        {
            if (primeiroDaFila > ultimoDaFila)
            {
                return 0;
            } else
            {
                return (ultimoDaFila - primeiroDaFila) + 1;
            }
        }

      
    }
}
