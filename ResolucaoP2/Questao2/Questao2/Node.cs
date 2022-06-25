using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Node
    {
        string valor;
        Node ramoEsquerdo;
        Node ramoDireito;

        public Node(string valor)
        {
            this.valor = valor;
            this.ramoEsquerdo = null;
            this.ramoDireito = null;
        }

        public string Valor { get => valor; set => valor = value; }
        public Node RamoEsquerdo { get => ramoEsquerdo; set => ramoEsquerdo = value; }
        public Node RamoDireito { get => ramoDireito; set => ramoDireito = value; }
    }

}