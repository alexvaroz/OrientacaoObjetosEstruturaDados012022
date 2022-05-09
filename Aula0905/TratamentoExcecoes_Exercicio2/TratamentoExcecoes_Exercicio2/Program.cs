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
            try {
                Console.WriteLine($"O resultado é " +
                    $"{CalcularRaizQuadradaNumero(numeroDigitado)}");
            }
            catch (NegativeNumberException nne)
            {
                Console.WriteLine(nne.Message);
            }
            finally
            {
                Console.WriteLine("Cálculo finalizado");
            }
            Console.ReadLine();
        }

        static double CalcularRaizQuadradaNumero(double numero)
        {

            if (numero < 0)
            {
                throw new NegativeNumberException("Só são aceitos números postivos");
            }
            return Math.Sqrt(numero);

        }    
        
    }
}
