using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Completo
{
    class ContaCorrente : Conta
    {
        const double TarifaSaque = 0.37 / 100;
        const double TarifaTransferencia = 0.10 / 100;

        public ContaCorrente(string numeroConta, string nomeCorrentista):
            base(numeroConta,nomeCorrentista)
        {        }

        public void Sacar(double quantia)
        {
            base.Sacar(quantia, TarifaSaque);
        }

        public void TransferirQuantiaParaOutraConta(
            double quantia, Conta outraConta)
        {
            base.TransferirQuantiaParaOutraConta(
                quantia, outraConta, TarifaTransferencia);
        }
    }
}
