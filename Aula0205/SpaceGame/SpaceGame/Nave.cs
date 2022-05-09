using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Nave: IObjetoDestrutivel, IObjetoMovel
    {
        String nome;
        int combustivel;
        int energia;
        int velocidade;
        int posicaoX;
        int posicaoY;


        public Nave(string nome, int combustivel, int energia, 
            int velocidade, int posicaoX, int posicaoY)
        {
            this.nome = nome;
            this.combustivel = combustivel;
            this.energia = energia;
            this.velocidade = velocidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }

        public Nave(string nome, int combustivel, int energia,
          int velocidade)
        {
            new Nave(nome, combustivel, energia,
             velocidade, 0, 0);
        }
        public string Nome
        {
            get
            {
                return nome;
            }

        }

        public int Combustivel
        {
            get
            {
                return combustivel;
            }

            set
            {
                combustivel = value;
            }
        }

        public int Energia
        {
            get
            {
                return energia;
            }

            set
            {
                energia = value;
            }
        }

        public int Velocidade
        {
            get
            {
                return velocidade;
            }

            set
            {
                velocidade = value;
            }
        }

        public int PosicaoX
        {
            get
            {
                return posicaoX;
            }

            set
            {
                posicaoX = value;
            }
        }

        public int PosicaoY
        {
            get
            {
                return posicaoY;
            }

            set
            {
                posicaoY = value;
            }
        }

        public void DanoLeve()
        {
            int danoLeve = 10;
            Energia -= danoLeve;
            VerificarSeDestruido();
        }

        public void DanoMedio()
        {
            int danoMedio = 25;
            Energia -= danoMedio;
            VerificarSeDestruido();
        }

        public void DanoGrave()
        {
            int danoGrave = 50;
            Energia -= danoGrave;
            VerificarSeDestruido();
        }

        public virtual void Movimentar()
        {
            PosicaoX = PosicaoX + Velocidade;
            PosicaoY = PosicaoY + Velocidade;
            Combustivel--;
        }

        public void VerificarSeDestruido()
        {
           if (Energia <= 0)
            {
                Console.WriteLine($"O objeto {Nome} foi destruído!");
            }
        }
    }
}
