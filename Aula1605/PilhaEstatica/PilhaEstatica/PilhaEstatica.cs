using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class PilhaEstatica
    {
        const String FULL_STACK = "A pilha já está cheia!!!";
        const String EMPTY_STACK = "A pilha está vazia!!!";
        int[] elementos;
        int topo;
        int qtdeElementos;

        public PilhaEstatica(int qtdeElementos)
        {
            this.elementos = new int[qtdeElementos];
            this.topo = -1;
            this.qtdeElementos = qtdeElementos;
        }

        public int[] Elementos
        {
            get
            {
                return elementos;
            }
        }

        public int Topo
        {
            get
            {
                return topo;
            }
        }

        public int QtdeElementos
        {
            get
            {
                return qtdeElementos;
            }
        }

        public void Push(int numero)
        {
            if (topo < qtdeElementos-1)
            {
                topo++;
                elementos[topo] = numero;
            } else
            {
                throw new FullStackException(FULL_STACK);
            }            
        }

        public int Pop()
        {
            if (topo > -1)
            {
                int elemento = elementos[topo];
                topo--;
                return elemento;
            } else
            {
                throw new EmptyStackException(EMPTY_STACK);
            }   
        }

        public int Peek()
        {
            if (topo > -1)
            {
                return elementos[topo];
            }
            else
            {
                throw new EmptyStackException(EMPTY_STACK);
            }
        }
        
        public void PrintStack()
        {
            if (topo > -1)
            {
                for (int i = topo; i >= 0 ; i--)
                {
                    Console.WriteLine(elementos[i]);
                }
            }
            else
            {
                throw new EmptyStackException(EMPTY_STACK);
            }
        }   
        
        public int Count()
        {
            return topo + 1;
        }
    }
}
