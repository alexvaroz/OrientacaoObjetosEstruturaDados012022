using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("cinza", 2017, "Cadilac", 185);
            
            Console.WriteLine($"O meu carro é do modelo {meuCarro.modelo}, ");
            Console.WriteLine($"do ano {meuCarro.anoFabricacao}, cor {meuCarro.cor}, ");
            Console.WriteLine($"que alcança até {meuCarro.velocidadeMaxima} Km/h");
            Console.ReadLine();
            meuCarro.Ligar();
            Console.ReadLine();
            meuCarro.Ligar();
            meuCarro.Ligar();
            meuCarro.Ligar();
            meuCarro.Ligar();
            meuCarro.Ligar();
            Console.ReadLine();
        }
    }
}
