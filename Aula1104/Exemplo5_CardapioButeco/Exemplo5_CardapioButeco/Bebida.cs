using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_CardapioButeco
{
    class Bebida:ItemMenu
    {
        double precoPequeno;
        double precoMedio;
        double precoGrande;

        public Bebida(string nome, double precoPequeno, double precoMedio, 
            double precoGrande):base(nome)
        {
            this.precoPequeno = precoPequeno;
            this.precoMedio = precoMedio;
            this.precoGrande = precoGrande;
        }

        public double PrecoPequeno
        {
            get
            {
                return precoPequeno;
            }

        }

        public double PrecoMedio
        {
            get
            {
                return precoMedio;
            }
        }

        public double PrecoGrande
        {
            get
            {
                return precoGrande;
            }
        }

        public override string InformarPreco()
        {
            return($" - Tamanho Pequeno: {precoPequeno.ToString("C")} \n"+
                   $" - Tamanho Médio: {precoMedio.ToString("C")} \n" +
                   $" - Tamanho Grande: {precoGrande.ToString("C")}");
        }
    }
}
