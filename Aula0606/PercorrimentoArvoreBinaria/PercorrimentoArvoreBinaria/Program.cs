using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercorrimentoArvoreBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeG = new Node('G');
            Node nodeF = new Node('F', nodeG, null);
            Node nodeD = new Node('D');
            Node nodeE = new Node('E');
            Node nodeB = new Node('B', nodeD, nodeE);
            Node nodeC = new Node('C', null, nodeF);
            Node nodeA = new Node('A', nodeB, nodeC);

            ArvoreBinaria minhaArvore = new ArvoreBinaria(nodeA);

            Console.WriteLine("Percurso PréFixado:");
            PercursoPreFixado(minhaArvore.Raiz);
            Console.WriteLine();
            Console.WriteLine("Percurso InFixado:");
            PercursoInFixado(minhaArvore.Raiz);
            Console.WriteLine();
            Console.WriteLine("Percurso PosFixado:");
            PercursoPosFixado(minhaArvore.Raiz);

            Console.ReadLine();         
             
        }

        static Node BuscarElementoArvore(char elemento, Node raizArvore)
        {
            Node resultado;
            if (raizArvore == null)
            {
                Console.Clear();
                Console.WriteLine("Elemento não encontrado");
                return null;
            } else
            {
                if (raizArvore.Elemento == elemento)
                {
                    Console.Clear();
                    Console.WriteLine("Elemento encontrado");
                    return raizArvore;
                } else
                {
                    resultado = BuscarElementoArvore(elemento, raizArvore.RamoEsquerdo);
                    if (resultado == null)
                    {
                        resultado = BuscarElementoArvore(elemento, raizArvore.RamoDireito);
                    }
                    return resultado;
                }
            }
        }

      static void PercursoPreFixado(Node raizArvore)
        {
            if (raizArvore != null)
            {
                Console.Write($"{raizArvore.Elemento}\t");
                PercursoPreFixado(raizArvore.RamoEsquerdo);
                PercursoPreFixado(raizArvore.RamoDireito);
            }
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

        static void PercursoPosFixado(Node raizArvore)
        {
            if (raizArvore != null)
            {
                PercursoPosFixado(raizArvore.RamoEsquerdo);
                PercursoPosFixado(raizArvore.RamoDireito);
                Console.Write($"{raizArvore.Elemento}\t");
            }
        }

    }
}
