using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaDeBusca
{
    // Testar a inserção de elementos na árvore de busca binária criada
    class Program
    {
        static void Main(string[] args)
        {
            Arvore minhaArvore = new Arvore();
            int[] numerosAInserir = { 40, 30, 15, 50, 45, 13, 80, 71, 20 };
            foreach (int item in numerosAInserir)
            {
                minhaArvore.InserirElemento(item);
            }
            PercursoInFixado(minhaArvore.Raiz);
            Console.ReadLine();
        }

        static void PercursoInFixado(Node raizArvore)
        {
            if (raizArvore != null)
            {
                PercursoInFixado(raizArvore.RamoEsquerdo);
                Console.Write($"{raizArvore.Elemento}\t");
                PercursoInFixado(raizArvore.RamoDireito);
            }
        } 
    }
}
