using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Completo
{
    abstract class Conta
    {
        String numeroConta;
        String nomeCorrentista;
        double saldoAtual;

        public Conta(string numeroConta, string nomeCorrentista)
        {
            this.numeroConta = numeroConta;
            this.nomeCorrentista = nomeCorrentista;
            this.saldoAtual = 0;
        }

        public string NumeroConta
        {
            get
            {
                return numeroConta;
            }

        }

        public string NomeCorrentista
        {
            get
            {
                return nomeCorrentista;
            }

        }

        public double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }
        }


        public virtual void Sacar(double quantia, double tarifaSaque)
        {
            double valorDebitado = quantia + quantia * tarifaSaque;
            if ((SaldoAtual - valorDebitado) >= 0)
            {
                ReduzirSaldo(valorDebitado);
            }
            else
            {
                throw new Exception("Não foi possível realizar saque");
            }
        }

        public virtual void TransferirQuantiaParaOutraConta(
            double quantia, Conta outraConta, double tarifaTransferencia)
        {
            double valorDebitado = quantia + quantia * tarifaTransferencia;
            if ((SaldoAtual - valorDebitado) >= 0)
            {
                ReduzirSaldo(valorDebitado);
                outraConta.DepositarQuantia(quantia);
            }
            else
            {
                throw new Exception("Não foi possível realizar a transferência");
            }
        }


        protected void ReduzirSaldo(double quantia)
        {
            saldoAtual -= quantia;
        }

        protected void AumentarSaldo(double quantia)
        {
            saldoAtual += quantia;
        }

        public double ConsultarSaldo()
        {
            return saldoAtual;
        }

        public void DepositarQuantia(double quantia)
        {
            AumentarSaldo(quantia);
        }

    }
}
