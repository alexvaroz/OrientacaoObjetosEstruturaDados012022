using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class NaveAtaque : Nave
    {
        int potenciaTiro;
        int velocidadeTiro;

        public NaveAtaque(string nome, int combustivel, int energia, 
            int velocidade, int posicaoX, int posicaoY, int potenciaTiro, 
            int velocidadeTiro) : base(nome, combustivel, energia, velocidade,
                posicaoX, posicaoY)
        {
            this.potenciaTiro = potenciaTiro;
            this.velocidadeTiro = velocidadeTiro;
        }

        public NaveAtaque(string nome, int combustivel, int energia,
            int velocidade, int potenciaTiro,
            int velocidadeTiro) : base(nome, combustivel, energia, velocidade
                )
        {
            this.potenciaTiro = potenciaTiro;
            this.velocidadeTiro = velocidadeTiro;
        }
        

        public int PotenciaTiro
        {
            get
            {
                return potenciaTiro;
            }

            set
            {
                potenciaTiro = value;
            }
        }

        public int VelocidadeTiro
        {
            get
            {
                return velocidadeTiro;
            }

            set
            {
                velocidadeTiro = value;
            }
        }

        public Tiro Atirar()
        {
            return new Tiro(potenciaTiro, velocidadeTiro, PosicaoX, PosicaoY);
        }
    }
}
