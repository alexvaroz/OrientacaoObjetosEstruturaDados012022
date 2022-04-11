using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Spoiler
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca contaPoupancaTestolfo = new ContaPoupanca(
                "71717-1", "Testolfo Rocha");
            contaPoupancaTestolfo.DepositarValor(150000);

            Console.WriteLine(contaPoupancaTestolfo.SacarValor(149000));

            Con
            Console.ReadLine();
        }
    }
}
