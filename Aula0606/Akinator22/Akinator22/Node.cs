using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akinator22
{
    class Node
    {
        Node nodeYes;
        String informacao;
        Node nodeNo;

        public Node(Node nodeYes, string informacao, Node nodeNo)
        {
            this.nodeYes = nodeYes;
            this.informacao = informacao;
            this.nodeNo = nodeNo;
        }

        internal Node NodeYes
        {
            get
            {
                return nodeYes;
            }

            set
            {
                nodeYes = value;
            }
        }

        public string Informacao
        {
            get
            {
                return informacao;
            }
        }

        internal Node NodeNo
        {
            get
            {
                return nodeNo;
            }

            set
            {
                nodeNo = value;
            }
        }

        public void ProcessarNode()
        {
            if (SeQuestao()) {
                Console.WriteLine(informacao);
                Console.WriteLine("Digite 's' para SIM e 'n' para NÃO:");
                char resposta = char.Parse(Console.ReadLine());
                if (resposta == 's')
                {
                    nodeYes.ProcessarNode();
                } else
                {
                    nodeNo.ProcessarNode();
                }
            } else
            {
                ApresentarResposta();
            }
        }

        private void ApresentarResposta()
        {
            Console.WriteLine($"Você pensou em {informacao}?");
            Console.WriteLine("Digite 's' para SIM e 'n' para NÃO:");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's')
            {
                Console.WriteLine("Essa foi fácil!!! Show!!!");
            }
            else
            {
                Console.WriteLine("Poxa... que pena...");
                Console.WriteLine("No que você estava pensando??");
                String informacaoCorreta = Console.ReadLine();
                Console.WriteLine($"Qual seria a pergunta para diferenciar {informacao} de {informacaoCorreta}??");
                String novaPergunta = Console.ReadLine();
                Console.WriteLine($"Para {informacaoCorreta}, qual seria a resposta? (s) ou (n) ");
                char respostaNovaPergunta = char.Parse(Console.ReadLine());
                if (respostaNovaPergunta == 's')
                {
                    nodeYes = new Node(null, informacaoCorreta, null);
                    nodeNo = new Node(null, informacao, null);
 
                } else
                {
                    nodeNo = new Node(null, informacaoCorreta, null);
                    nodeYes = new Node(null, informacao, null);
                }

            }

        }

        private bool SeQuestao()
        {
            if (nodeYes == null && nodeNo == null)
            {
                return false;
            }
            else return true;
        }
    }
}
