using System;
using System.Collections;
using System.Collections.Generic;

namespace EstudoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array List
            ArrayList meuArrayList = new ArrayList();
            meuArrayList.Add("Bob Nelson");
            meuArrayList.Add(22);
            meuArrayList.Add(true);
            Console.WriteLine(meuArrayList.IndexOf(22));

            // List<T>
            List<object> minhaLista = new List<object>();
            minhaLista.Add("Bob Nelson");
            minhaLista.Add("Testolfo");
            minhaLista.Add(22);
            Console.ReadLine();

            List<int> listaA = new List<int>();
            List<int> listaB = new List<int>();

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                listaA.Add(rnd.Next(0, 51));
                listaB.Add(rnd.Next(0, 51));
            }

            List<int> listaUniao = new List<int>();
            List<int> listaInterseccao = new List<int>();

            // Operação de União
            foreach (var item in listaB)
            {
                if (listaA.Contains(item))
                {
                    listaInterseccao.Add(item);
                }
                else
                {
                    listaUniao.Add(item);
                }
            }
            listaUniao.AddRange(listaA);

            Console.WriteLine("Lista A");
            ImprimirLista(listaA);
            Console.WriteLine("Lista B");
            ImprimirLista(listaB);
            Console.WriteLine("Lista Interseccao");
            ImprimirLista(listaInterseccao);
            Console.WriteLine("Lista União");
            ImprimirLista(listaUniao);
            Console.ReadLine();
        }

        private static void ImprimirLista(List<int> listaUniao)
        {
            foreach (var item in listaUniao)
            {
                Console.WriteLine(item);
            }
        }
    }
}
