using System;
using System.Collections.Generic;

namespace EstudoSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> listaAlunos = new HashSet<String>();
            listaAlunos.Add("Bob Nelson");
            listaAlunos.Add("Testolfo Rocha");
            listaAlunos.Add("Bela Margarida");
            listaAlunos.Add("Bob Nelson");
            listaAlunos.Add("Bob Nelson");
            listaAlunos.Add("Bob Nelson");

            SortedSet<String> listaAlunosSorted = new SortedSet<String>();
            listaAlunosSorted.Add("Bob Nelson");
            listaAlunosSorted.Add("Testolfo Rocha");
            listaAlunosSorted.Add("Bela Margarida");
            listaAlunosSorted.Add("Bob Nelson");
            listaAlunosSorted.Add("Bob Nelson");
            listaAlunosSorted.Add("Bob Nelson");

            foreach (var item in listaAlunosSorted)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
