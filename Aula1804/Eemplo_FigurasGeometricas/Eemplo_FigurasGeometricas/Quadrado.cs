using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    class Quadrado : FiguraGeometrica
    {
        const int NUMERO_LADOS_QUADRADO = 4;

        public Quadrado(double medida) : base(medida) { }

        public override double CalcularArea()
        {
            return Medida * Medida;
        }

        public override double CalcularPerimetro()
        {
            return NUMERO_LADOS_QUADRADO * Medida;
        }
    }
}
