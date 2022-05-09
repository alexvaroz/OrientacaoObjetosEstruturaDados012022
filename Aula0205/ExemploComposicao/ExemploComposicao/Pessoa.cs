using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploComposicao
{
    class Pessoa
    {
        string nome;
        int idade;
        Emprego empregoAtual;

        public Pessoa(string nome, int idade, Emprego empregoAtual)
        {
            this.nome = nome;
            this.idade = idade;
            this.empregoAtual = empregoAtual;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
        }

        internal Emprego EmpregoAtual
        {
            get
            {
                return empregoAtual;
            }
        }
    }
}
