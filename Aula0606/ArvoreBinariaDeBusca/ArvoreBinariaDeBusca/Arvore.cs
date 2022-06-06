using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDeBusca
{
    class Arvore
    {
        Node raiz;

        internal Node Raiz
        {
            get
            {
                return raiz;
            }
        }

        public void InserirElemento(int elemento)
        {
            Node novoNode = new Node(elemento);
            this.raiz = InserirNovoNode(raiz, novoNode);
        }

        private Node InserirNovoNode(Node nodeAtual, Node novoNode)
        {
            if (nodeAtual == null)
            {
                nodeAtual = novoNode;
                return nodeAtual;
            } else
            {
                if (nodeAtual.Elemento > novoNode.Elemento)
                {
                    nodeAtual.RamoEsquerdo = InserirNovoNode(nodeAtual.RamoEsquerdo, 
                        novoNode);
                } else
                {
                    nodeAtual.RamoDireito = InserirNovoNode(nodeAtual.RamoDireito, 
                        novoNode);
                }
                return nodeAtual;
            }
        }
    }
}
