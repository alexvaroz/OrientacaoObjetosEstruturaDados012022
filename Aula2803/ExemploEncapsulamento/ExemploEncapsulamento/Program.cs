using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro toto = new Cachorro("Tótó", "PitBull", 3);
            toto.Nome = "Fox";
            Console.WriteLine($"O nome do cachorro é {toto.Nome}");
            Console.ReadLine();
        }
    }
}
