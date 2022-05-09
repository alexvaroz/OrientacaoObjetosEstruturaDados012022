using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Emprego gameDesigner = new Emprego("Game Designer", 10000);

            Pessoa pessoaTestolfo = new Pessoa("Testolfo Rocha", 35, gameDesigner);
            Pessoa pessoaBob = new Pessoa("Bob Nelson",
                49, gameDesigner );

            Console.WriteLine($"O salário atual do {pessoaBob.Nome} é {pessoaBob.EmpregoAtual.SalarioAtual.ToString("C")}");

            Console.WriteLine($"O salário atual do {pessoaTestolfo.Nome} é {pessoaTestolfo.EmpregoAtual.SalarioAtual.ToString("C")}");

            pessoaBob.EmpregoAtual.ReajustarSalario(2000);
            Console.ReadLine();

            Console.WriteLine($"O salário atual do {pessoaBob.Nome} é {pessoaBob.EmpregoAtual.SalarioAtual.ToString("C")}");

            Console.WriteLine($"O salário atual do {pessoaTestolfo.Nome} é {pessoaTestolfo.EmpregoAtual.SalarioAtual.ToString("C")}");
            Console.ReadLine();


        }
    }
}
