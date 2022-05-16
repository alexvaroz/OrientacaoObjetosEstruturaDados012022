using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaEstatica
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                PilhaEstatica minhaPilha = new PilhaEstatica(3);
                minhaPilha.Push(10);
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                minhaPilha.Push(11);
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                minhaPilha.Push(17);
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine("Imprimindo a Pilha:");
                minhaPilha.PrintStack();
                Console.ReadLine();
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                minhaPilha.Push(100);
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");
                Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");
                Console.WriteLine($"Topo da pilha é: {minhaPilha.Peek()}");

                //Console.WriteLine($"Número retirado: {minhaPilha.Pop()}");

            } catch (FullStackException fse) {
                Console.WriteLine(fse.Message);
            }
           catch (EmptyStackException ese) {
                Console.WriteLine(ese.Message);
            }
    Console.ReadLine();
        }
    }
}
