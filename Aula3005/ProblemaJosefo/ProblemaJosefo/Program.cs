using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaJosefo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listaAmigosJosefus = {"Bob",
            "Nelson", "Testolfo", "Rocha", "Tim", "Tom",
            "Tati", "Jack", "Josephus", "Jon"};

            Queue<String> filaAmigos = new Queue<String>();
            foreach (String pessoa in listaAmigosJosefus)
            {
                filaAmigos.Enqueue(pessoa);
            }

            while (filaAmigos.Count > 1)
            {
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                filaAmigos.Enqueue(filaAmigos.Dequeue());
                Console.WriteLine($"{filaAmigos.Peek()} foi o felizardo da vez...");
                filaAmigos.Dequeue();
            }
            Console.WriteLine($"{filaAmigos.Peek()} sobreviveu...");
            Console.ReadLine();


        }
    }
}
