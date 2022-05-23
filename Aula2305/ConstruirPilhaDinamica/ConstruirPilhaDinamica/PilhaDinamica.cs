﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirPilhaDinamica
{
    class PilhaDinamica
    {
        const String PILHA_VAZIA = "A pilha está vazia.";
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

        // Operacoes: Push, Pop, Peek, Count, ToArray
        public void Push(string dado)
        {
            Node novoNode = new Node(dado);
            novoNode.Elo = topo;
            topo = novoNode;
        }

        public void Pop()
        {
            if (topo != null)
            {
                topo = topo.Elo;
            }
            else
            {
                throw new EmptyStackException(PILHA_VAZIA);
            }
        }

        public String Peek()
        {
            if (topo != null)
            {
                return topo.Dado;
            }
            else
            {
                throw new EmptyStackException(PILHA_VAZIA);
            }
        }

        public int Count()
        {
            int qtdeElementos = 0;
            Node nodeAuxiliar = topo;
            if (topo == null)
            {
                return qtdeElementos;
            }
            else
            {
                qtdeElementos++;
                while (nodeAuxiliar.Elo != null)
                {
                    qtdeElementos++;
                    nodeAuxiliar = nodeAuxiliar.Elo;
                }
                return qtdeElementos;
            }
        }

            public string[] ToArray()
        {
            string[] elementos = new string[Count()];
            Node nodeAuxiliar = topo;
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = nodeAuxiliar.Dado;
                nodeAuxiliar = nodeAuxiliar.Elo;
            }
            return elementos;
        }
        
    }
}



