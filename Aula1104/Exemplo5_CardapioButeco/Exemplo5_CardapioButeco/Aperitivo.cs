using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_CardapioButeco
{
    class Aperitivo : ItemMenu
    {
        double precoPorcao;

        public Aperitivo(string nome, double precoPorcao):base(nome)
        {
            this.precoPorcao = precoPorcao;
        }

        public double PrecoPorcao
        {
            get
            {
                return precoPorcao;
            }
        }

        public override string InformarPreco()
        {
            return ($" - Porçõo: {precoPorcao.ToString("C")}");
        }
    }
}
