using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    abstract class FiguraGeometrica
    {
        double medida;

        public FiguraGeometrica(double medida)
        {
            this.medida = medida;
        }

        public double Medida
        {
            get
            {
                return medida;
            }
        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();

    }
}
