using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humanoTeste = new Humano("Bob", "Nelson");
            Console.WriteLine(humanoTeste.InformarNomeCompleto());

            Estudante estudanteTeste = new Estudante("Testolfo" , "Rocha", 7);
            
            Console.WriteLine(estudanteTeste.InformarNomeCompleto());
            Console.WriteLine($"{estudanteTeste.InformarNomeCompleto()} "+
                $"tirou a nota {estudanteTeste.notaFinal}");

            Trabalhador trabalhadorTeste = new Trabalhador("Bob", "Nelson", 5000, 160);
            Console.WriteLine($"{trabalhadorTeste.InformarNomeCompleto()} " +
                $"recebe por hora o valor de {trabalhadorTeste.ObterValorPorHora().ToString("C")}");
            Console.ReadLine();
        }
    }
}
