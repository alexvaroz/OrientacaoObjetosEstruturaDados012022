using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAkinator2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree gameTree = GameSetup();
            Console.WriteLine("Iniciando o jogo");
            gameTree.Root.ProcessNode();
            while (PlayAgain())
            {
                Console.Clear();
                gameTree.Root.ProcessNode();
            }

        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Vamos jogar novamente?");
            char userAnswer = Console.ReadLine()[0];
            if(userAnswer == 's')
            {
                return true;
            } else
            {
                return false;
            }
        }

        private static Tree GameSetup()
        {
            Console.WriteLine("Inicializando o jogo....");
            Console.WriteLine("Apresente uma pergunta sobre uma fruta:");
            String firstQuestion = Console.ReadLine();
            Console.WriteLine("Se a resposta for 's', qual seria a fruta?");
            String yesAnswer = Console.ReadLine();
            Console.WriteLine("Se a resposta for 'n', qual seria a fruta?");
            String noAnswer = Console.ReadLine();
            Node rootNode = new Node(firstQuestion, new Node(yesAnswer), new Node(noAnswer));
            Tree gameTree = new Tree(rootNode);
            return gameTree;
        }
    }
}
