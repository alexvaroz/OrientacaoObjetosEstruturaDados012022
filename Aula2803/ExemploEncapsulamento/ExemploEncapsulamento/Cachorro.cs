using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Cachorro
    {
        String nome;
        String raca;
        int idade;

        public Cachorro(string nome, string raca, int idade)
        {
            this.Nome = nome;
            this.Raca = raca;
            this.Idade = idade;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Raca
        {
            get
            {
                return raca;
            }

            set
            {
                raca = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }
    }
}
