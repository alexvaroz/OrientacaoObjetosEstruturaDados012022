using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes_Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número inteiro:");
            LerEImprimirNumeroInteiro();
            Console.ReadLine();
        }

        private static void LerEImprimirNumeroInteiro()
        {
            try {
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"O número digitado foi {numero} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu o erro: {e.Message}");
                Console.WriteLine("Tente novamente...");
                LerEImprimirNumeroInteiro();
                Console.ReadLine();
            }
        }
    }
}
