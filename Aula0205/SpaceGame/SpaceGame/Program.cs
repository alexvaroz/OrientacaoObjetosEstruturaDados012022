using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            NaveAtaque naveAtaqueBob = new NaveAtaque("Alfa Bob 1", 30, 
                50, 100, 40, 70);
            NaveAtaque navePirata1 = new NaveAtaque("Nave Pirata 1", 20,
                40, 80, 25, 25, 30, 50);
            NaveAtaque navePirata2 = new NaveAtaque("Nave Pirata 2", 20,
              40, 80, 15, 70, 30, 50);
            NaveAtaque navePirata3 = new NaveAtaque("Nave Pirata 3", 20,
              40, 80, 40, 30, 30, 50);

            Asteroide asteroideAlfa = new Asteroide(20, 25, 20, 20);
            Asteroide asteroideBeta = new Asteroide(20, 25, 35, 35);

            naveAtaqueBob.Atirar();
            navePirata1.DanoLeve();
            naveAtaqueBob.Atirar();
            navePirata2.DanoGrave();
            naveAtaqueBob.Atirar();
            navePirata3.DanoMedio();
            naveAtaqueBob.Atirar();
            navePirata1.DanoLeve();
            naveAtaqueBob.Atirar();
            naveAtaqueBob.Atirar();
            navePirata3.DanoMedio();
            naveAtaqueBob.Atirar();
            navePirata1.DanoMedio();
            Console.ReadLine();
            
        }
    }
}
