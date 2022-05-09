using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividendo = 9;
            int divisor = 0;
            Console.WriteLine(DividirDoisNumeros(dividendo, divisor));
            Console.ReadLine();
        }

        static int DividirDoisNumeros(int dividendo, int divisor)
        {
            try {
                if (dividendo == 0)
                {
                    throw new Exception("O resultado da divisão não pode ser zero");
                }
                int resultado = dividendo / divisor;
                return resultado;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu uma exceção");
                return -1;
            }

            
        }
    }
}
