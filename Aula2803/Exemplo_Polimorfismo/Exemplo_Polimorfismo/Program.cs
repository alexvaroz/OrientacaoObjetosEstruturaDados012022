using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            JogoDigital jogoMario = new JogoDigital("Nintendo",
                "Mário Kart 8", "SuperNintendo", 549.00f);
            JogoDigital jogoSonic = new JogoDigital("Sega",
                "Sonic Adventure", "MegaDrive", 317.34f);
            Livro livroProgramacao = new Livro("Clean Code", "Martin F.", 53.54f);
            Livro livroQuadrinhos = new Livro("Turma da Mônica", "Maurício de S.", 17.91f);

            Console.WriteLine("Catálogo da Loja ACME:");
            Console.WriteLine($"{jogoMario.InformarDescricao()}");
            Console.WriteLine($"Valor: {jogoMario.InformarPreco()}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{jogoSonic.InformarDescricao()}");
            Console.WriteLine($"Valor: {jogoSonic.InformarPreco()}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{livroProgramacao.InformarDescricao()}");
            Console.WriteLine($"Valor: {livroProgramacao.InformarPreco()}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"{livroQuadrinhos.InformarDescricao()}");
            Console.WriteLine($"Valor: {livroQuadrinhos.InformarPreco()}");
            Console.ReadLine();

        }
    }
}
