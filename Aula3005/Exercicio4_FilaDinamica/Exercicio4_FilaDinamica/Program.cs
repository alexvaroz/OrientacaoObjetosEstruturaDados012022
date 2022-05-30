using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_FilaDinamica
{
    class Program
    {
        /* 
        Implementar um sistema de gerenciamento de senhas geradas para fila de 
        atendimento. O sistema deve ser capaz de gerar a senha, incluir na fila, 
        listar as senhas da fila e retirar o elemento da fila quando for 
        chamado.
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem Vindo");
            Boolean continuar = true;
            PainelAtentimento painel = new PainelAtentimento();
            while (continuar)
            {
                GerarMenu();
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        painel.GerarSenha();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine(painel.ChamarSenha());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        painel.AtenderSenha();
                        Console.Clear();
                        break;
                    case 4:
                        painel.MostrarUltimaSenhaAtendida();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        painel.MostrarListaEspera();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }

        static void GerarMenu()
        {
            Console.WriteLine("Digite a opção:");
            Console.WriteLine("(1) Gerar senha");
            Console.WriteLine("(2) Chamar senha");
            Console.WriteLine("(3) Atender senha");
            Console.WriteLine("(4) Mostrar última senha");
            Console.WriteLine("(5) Mostrar fila de espera");
            Console.WriteLine("(6) Sair");
        }
    }
}
