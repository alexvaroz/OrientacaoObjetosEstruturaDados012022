using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class ArvoreBinaria
    {
        Node raiz;
              
        public Node Raiz { get => raiz; set => raiz = value; }

        public void InserirNoBin(Node novoNo)
        {
            Raiz = Inserir(Raiz, novoNo);
        }

        private Node Inserir(Node atual, Node novoNo)
        {
            if (atual == null)
            {
                return novoNo;
            }
            else if (novoNo.Valor.CompareTo(atual.Valor) < 0)
            {
                atual.RamoEsquerdo = Inserir(atual.RamoEsquerdo, novoNo);
            }
            else
            {
                atual.RamoDireito = Inserir(atual.RamoDireito, novoNo);
            }
            return atual;

        }
    }

}
