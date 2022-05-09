using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Asteroide : IObjetoMovel, IObjetoDestrutivel
    {
        int energia;
        int velocidade;
        int posicaoX;
        int posicaoY;

        public Asteroide(int energia, int velocidade, int posicaoX, int posicaoY)
        {
            this.energia = energia;
            this.velocidade = velocidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
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

        public void Movimentar()
        {
            posicaoX = posicaoX + Velocidade;
            posicaoY = posicaoY + Velocidade;
        }

        public void DanoLeve()
        {
            int danoLeveAsteroide = 10;
            Energia -= danoLeveAsteroide;
            VerificarSeDestruido();
        }

        public void DanoMedio()
        {
            int danoMedioAsteroide = 20;
            Energia -= danoMedioAsteroide;
            VerificarSeDestruido();
        }

        public void DanoGrave()
        {
            int danoGraveAsteroide = 20;
            Energia -= danoGraveAsteroide;
            VerificarSeDestruido();
        }

        public void VerificarSeDestruido()
        {
            if (Energia <= 0)
            {
                Console.WriteLine($"O asteróide foi destruído!");
            }
        }
    }
}
