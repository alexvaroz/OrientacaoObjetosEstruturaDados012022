using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_CardapioButeco
{
    class Cigarro : ItemMenu, IAvisoRestricao
    {
        double precoMaco;
         
        public Cigarro(string nome, double precoMaco) : base(nome) {
            this.precoMaco = precoMaco;
        }

        public double PrecoMaco
        {
            get
            {
                return precoMaco;
            }

        }

        public string AvisarResticaoVendaMenores()
        {
            return "Proibida a venda a menores. Fumar é prejudicial à saúde.";
        }

        public override string InformarPreco()
        {
            return AvisarResticaoVendaMenores() +"\n" +
                $" - Maço: {precoMaco.ToString("C")}";
        }

       
    }
}
