using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Spoiler
{
    class Conta
    {
        private String idConta;
        private String nomeCorrentita;
        protected double saldoAtual;

        public Conta(string idConta, string nomeCorrentita)
        {
            this.idConta = idConta;
            this.nomeCorrentita = nomeCorrentita;
            this.saldoAtual = 0;
        }

        protected string IdConta
        {
            get
            {
                return idConta;
            }

        }

        protected string NomeCorrentita
        {
            get
            {
                return nomeCorrentita;
            }

        }

        protected double SaldoAtual
        {
            get
            {
                return saldoAtual;
            }
        }

        public virtual String SacarValor(double valor)
        {
            return "Operação não realizada";
        }

        public void DepositarValor(double valor)
        {
            saldoAtual = saldoAtual + valor;
        }
    }
}
