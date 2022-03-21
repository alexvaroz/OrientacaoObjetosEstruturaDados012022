using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorroBoni = new Cachorro();
            cachorroBoni.nome = "Boni";
            cachorroBoni.raca = "Maltez";
            cachorroBoni.idade = 2;
            cachorroBoni.peso = 3.5f;

            Cachorro cachorroOdin = new Cachorro();
            cachorroOdin.nome = "Odin";
            cachorroOdin.raca = "Fox Paulistinha";
            cachorroOdin.idade = 5;
            cachorroOdin.peso = 3.7f;

            Cachorro[] cachorros = {cachorroBoni, cachorroOdin};

            foreach (Cachorro item in cachorros)
            {
                Console.WriteLine($"O cachorro se chama {item.nome}");
                Console.WriteLine($"Ele é da raça {item.raca}");
                Console.WriteLine($"Ele tem {item.idade} ano(s) e pesa {item.peso} kilos.");
                Console.WriteLine("");
                Console.ReadLine();
            }

            cachorroBoni.Latir();
            cachorroOdin.Latir();
            Console.ReadLine();

        }
    }


}
