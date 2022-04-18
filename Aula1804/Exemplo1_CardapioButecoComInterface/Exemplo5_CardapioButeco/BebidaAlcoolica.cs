using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_CardapioButeco
{
    class BebidaAlcoolica : Bebida, IAvisoRestricao
    {
        public BebidaAlcoolica(string nome, double precoPequeno, double precoMedio,
            double precoGrande):base(nome,precoPequeno, precoMedio, precoGrande)
        { }

        public override string InformarPreco()
        {
            return (AvisarResticaoVendaMenores() + "\n" +
                   $" - Tamanho Pequeno: {PrecoPequeno.ToString("C")} \n" +
                   $" - Tamanho Médio: {PrecoMedio.ToString("C")} \n" +
                   $" - Tamanho Grande: {PrecoGrande.ToString("C")}");
        }

        public string AvisarResticaoVendaMenores()
        {
            return "Proibida a venda a menores. Beba com moderação.";
        }
    }
}
