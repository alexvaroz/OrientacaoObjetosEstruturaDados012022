using System;
using System.Collections;
using System.Collections.Generic;

namespace EstudoLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            LinkedList<String> minhaListaEncadeada = new LinkedList<String>();
            minhaListaEncadeada.AddFirst("Janeiro");
            minhaListaEncadeada.AddFirst("Fevereiro");
            minhaListaEncadeada.AddFirst("Março");
            minhaListaEncadeada.AddLast("Abril");
            minhaListaEncadeada.Find("Março");
            minhaListaEncadeada.AddAfter(minhaListaEncadeada.Find("Março"), "Abril");
            minhaListaEncadeada.RemoveFirst();
            minhaListaEncadeada.RemoveFirst();
            minhaListaEncadeada.RemoveFirst();
            minhaListaEncadeada.AddAfter(minhaListaEncadeada.Find("Janeiro"), "Fevereiro");
            minhaListaEncadeada.AddLast("Dezembro");
            minhaListaEncadeada.AddBefore(minhaListaEncadeada.Find("Dezembro"), "Novembro");
            minhaListaEncadeada.AddAfter(minhaListaEncadeada.Find("Fevereiro"), "Março");

            foreach (var item in minhaListaEncadeada)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
