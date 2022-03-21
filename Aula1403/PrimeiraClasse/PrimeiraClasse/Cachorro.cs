using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    class Cachorro
    {
        //Atributos
        public String nome;
        public String raca;
        public int idade;
        public float peso;

        //Métodos
        public void Latir()
        {
            Console.WriteLine($"{nome} está latindo.");
        }
    }
}
