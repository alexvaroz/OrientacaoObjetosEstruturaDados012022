using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double numeroDigitado = double.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado é "+
                $"{CalcularRaizQuadradaNumero(numeroDigitado)}");
            Console.ReadLine();
        }

        static double CalcularRaizQuadradaNumero(double numero)
        {
            try {
                if (numero < 0)
                {
                    throw new NegativeNumberException("Só são aceitos números postivos");
                }
                return Math.Sqrt(numero);
            } catch (NegativeNumberException nne)
            {
                Console.WriteLine(nne.Message);
                return -1;
            }finally {
                Console.WriteLine("Cálculo finalizado");
            }
            
        }
    }
}
