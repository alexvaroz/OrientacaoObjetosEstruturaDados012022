using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    class Circulo : FiguraGeometrica
    {
        const double VALOR_PI = 22 / 7;

        public Circulo(double medida) : base(medida) { }

        public override double CalcularArea()
        {
            return VALOR_PI * Medida * Medida;
        }

        public override double CalcularPerimetro()
        {
            return 2 *VALOR_PI * Medida;
        }
    }
}
