using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    class Hexagono : FiguraGeometrica
    {
        const int NUMERO_LADOS_HEXAGONO = 6;

        public Hexagono(double medida) : base(medida) { }

        public override double CalcularArea()
        {
            return Medida * Medida * 3 * Math.Sqrt(3) / 2;
        }

        public override double CalcularPerimetro()
        {
           return NUMERO_LADOS_HEXAGONO * Medida;
        }
    }
}
