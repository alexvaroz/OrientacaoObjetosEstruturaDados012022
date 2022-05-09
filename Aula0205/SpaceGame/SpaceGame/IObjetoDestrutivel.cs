using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    interface IObjetoDestrutivel
    {
        void DanoLeve();
        void DanoMedio();
        void DanoGrave();
        void VerificarSeDestruido();


    }
}
