using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroComEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro primeiroCarro = new Carro("Prata", 1995, "Corsa", 150);
            Console.WriteLine($"O carro criado é da cor {primeiroCarro.Cor} ");
            Console.WriteLine($"Modelo {primeiroCarro.Modelo} ");
            Console.WriteLine($"Alcança {primeiroCarro.VelocidadeMaxima} km/h");
            if (primeiroCarro.EstahLigado)
            {
                primeiroCarro.Acelerar();
                primeiroCarro.Acelerar();
                primeiroCarro.Acelerar();
            } else
            {
                primeiroCarro.Ligar();
                primeiroCarro.Acelerar();
                primeiroCarro.Acelerar();
                primeiroCarro.Acelerar();
                primeiroCarro.Acelerar();
            }
            Console.WriteLine($"Velocidade atual: {primeiroCarro.VelocidadeAtual} km/h");

            Console.ReadLine();

        }
    }

  
}
