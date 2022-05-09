using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class NaveTransporte : Nave
    {
        int carga;

        public NaveTransporte(string nome, int combustivel, int energia,
            int velocidade, int posicaoX, int posicaoY, int carga) : 
            base(nome, combustivel, energia, velocidade,
                posicaoX, posicaoY)
        {
            this.carga = carga;
        }

        public NaveTransporte(string nome, int combustivel, int energia,
           int velocidade, int carga) :
           base(nome, combustivel, energia, velocidade)
        {
            this.carga = carga;
        }

        public int Carga
        {
            get
            {
                return carga;
            }

            set
            {
                carga = value;
            }
        }

        public override void Movimentar()
        {
            base.Movimentar();
            Combustivel -= Carga;
        }
    }
}
