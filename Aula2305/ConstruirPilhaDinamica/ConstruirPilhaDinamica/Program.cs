using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstruirPilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //TestarPilhaDInalica();
                Stack<Object> stack = new Stack<Object> ();
                stack.Push(25);
                stack.Push("Bob Nelson");
                stack.Push(true);
                Console.WriteLine(stack.Peek());
                Object[] elementos = stack.ToArray();
                foreach (var item in elementos)
                {
                    Console.Write($"{item}\t");
                }

            }
            catch (EmptyStackException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        private static void TestarPilhaDInalica()
        {
            PilhaDinamica primeiraPilha = new PilhaDinamica();
            Console.WriteLine(primeiraPilha.Count());
            primeiraPilha.Push("ABC");
            primeiraPilha.Push("DEF");
            primeiraPilha.Push("GHI");
            primeiraPilha.Push("JKL");
            string[] conteudo = primeiraPilha.ToArray();
            foreach (var item in conteudo)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            Console.WriteLine(primeiraPilha.Peek());
            primeiraPilha.Pop();
            primeiraPilha.Pop();
            Console.WriteLine(primeiraPilha.Peek());
        }
    }
}
