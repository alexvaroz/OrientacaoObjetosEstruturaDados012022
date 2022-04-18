using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    class Triangulo : FiguraGeometrica
    {
        const int NUMERO_LADOS_TRIANGULO = 3;

        public Triangulo(double medida):base(medida){}

        public override double CalcularArea()
        {
            Math.Sqrt(3);
            return Medida * Medida * (Math.Sqrt(3)) / 4;
        }

        public override double CalcularPerimetro()
        {
            return NUMERO_LADOS_TRIANGULO * Medida;
        }
    }
}
