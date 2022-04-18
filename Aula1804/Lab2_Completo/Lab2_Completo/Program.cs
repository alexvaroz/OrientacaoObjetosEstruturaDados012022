using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBob = new ContaCorrente("12345-6", "Bob Nelson");
            ContaPoupanca contaTestolfo = new ContaPoupanca("71717-1", 
                "Testolfo Rocha");
            ContaCorrente contaLisa = new ContaCorrente("65432-1", "Lisa Leite");

            // Operacoes
            contaBob.DepositarQuantia(5000);
            contaLisa.DepositarQuantia(2000);
            contaTestolfo.DepositarQuantia(1500);
            Console.WriteLine($"Saldo da conta do {contaBob.NomeCorrentista} " +
                $"é { contaBob.SaldoAtual.ToString("C")}");
            Console.ReadLine();
            contaBob.TransferirQuantiaParaOutraConta(600, contaTestolfo);
            contaLisa.Sacar(250);
            Console.WriteLine($"Saldo da conta do {contaBob.NomeCorrentista} " +
                $"é { contaBob.SaldoAtual.ToString("C")}");
            Console.ReadLine();
            Console.WriteLine($"Saldo da conta do {contaTestolfo.NomeCorrentista} " +
                $"é { contaTestolfo.SaldoAtual.ToString("C")}");
            Console.ReadLine();
            Console.WriteLine($"Saldo da conta do {contaLisa.NomeCorrentista} " +
                $"é { contaLisa.SaldoAtual.ToString("C")}");
            Console.ReadLine();
        }
    }
}
