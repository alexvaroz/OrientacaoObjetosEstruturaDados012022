using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Tiro : IObjetoMovel
    {
        int potencia;
        int velocidade;
        int posicaoX;
        int posicaoY;

        public Tiro(int potencia, int velocidade, int posicaoX, int posicaoY)
        {
            this.potencia = potencia;
            this.velocidade = velocidade;
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
        }

        public int Potencia
        {
            get
            {
                return potencia;
            }

        }

        public int Velocidade
        {
            get
            {
                return velocidade;
            }

        }

        public int PosicaoX
        {
            get
            {
                return posicaoX;
            }

  
        }

        public int PosicaoY
        {
            get
            {
                return posicaoY;
            }

        }

        public void Movimentar()
        {
            posicaoX = posicaoX + Velocidade;
            posicaoY = posicaoY + Velocidade;
        }
    }
}
