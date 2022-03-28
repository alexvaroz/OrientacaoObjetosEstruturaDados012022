using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarroComEncapsulamento
{
    class Carro
    {
        //Cor, Ano de fabricação, Modelo, VelocidadeAtual e VelocidadeMáxima, Ligado/Desligado.
        string cor;
        int anoFabricacao;
        string modelo;
        float velocidadeAtual;
        float velocidadeMaxima;
        Boolean estahLigado;

        public string Cor
        {
            get
            {
                return cor;
            }
        }

        public int AnoFabricacao
        {
            get
            {
                return anoFabricacao;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

        }

        public float VelocidadeAtual
        {
            get
            {
                return velocidadeAtual;
            }
        }

        public float VelocidadeMaxima
        {
            get
            {
                return velocidadeMaxima;
            }
        }

        public bool EstahLigado
        {
            get
            {
                return estahLigado;
            }
        }

        public Carro(string cor, int anoFabricacao, 
            string modelo, float velocidadeMaxima)
        {
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.modelo = modelo;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            this.estahLigado = false;
        }

        public void Ligar()
        {
            estahLigado = true;
        }

        public void Desligar()
        {
            estahLigado = false;
        }

        public void Acelerar()
        {
            int aceleracaoPadrao = 30;
            if (estahLigado)
            {
                velocidadeAtual += aceleracaoPadrao;
                if (velocidadeAtual >= velocidadeMaxima)
                {
                    velocidadeAtual = velocidadeMaxima;
                }
            }
        }

        public void Frear()
        {
            int desaceleracaoPadrao = 50;
            int velocidadeNula = 0;
            if (estahLigado)
            {
                velocidadeAtual -= desaceleracaoPadrao;
                if (velocidadeAtual < velocidadeNula)
                {
                    velocidadeAtual = velocidadeNula;
                }
            }
        }
    }
}
