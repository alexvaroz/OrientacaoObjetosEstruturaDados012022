using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Azul", "Fusca", 2003, 180f);

            meuCarro.LigarCarro();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            meuCarro.Frear();
            Console.ReadLine();

        }
    }
}
