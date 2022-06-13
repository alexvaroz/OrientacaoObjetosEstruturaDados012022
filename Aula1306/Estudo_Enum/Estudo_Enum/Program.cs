using System;

namespace Estudo_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            string nivelJogo = "Avancado";
            if (nivelJogo == NivelJogo.Medio.ToString())
            {
                Console.WriteLine("O nível está avançado!!");
            }
            Console.ReadLine();
        }
    }

    enum TipoAernave
    {
        NaveAtaque,
        NaveTransporte,
        NaveInimiga,
        NaveFantasma
    }
    
}
