using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirFilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                MinhaFila fila = new MinhaFila();
                fila.Enqueue("Bob Nelson");
                fila.Enqueue(3);
                fila.Enqueue("Testolfo Rocha");
                Console.WriteLine(fila.Peek());
                fila.Dequeue();
                Console.WriteLine(fila.Peek());
                fila.Dequeue();
                Console.WriteLine(fila.Peek());
            } catch (EmptyQueueException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
