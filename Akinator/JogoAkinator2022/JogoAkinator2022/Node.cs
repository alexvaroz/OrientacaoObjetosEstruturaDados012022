using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAkinator2022
{
    class Node
    {
        string content;
        Node nodeYes;
        Node nodeNo;

        public Node(string content, Node nodeYes, Node nodeNo)
        {
            this.content = content;
            this.nodeYes = nodeYes;
            this.nodeNo = nodeNo;
        }

        public Node(string content)
        {
            this.content = content;
            this.nodeYes = null;
            this.nodeNo = null;
        }

        public string Content { get => content; set => content = value; }
        internal Node NodeYes { get => nodeYes; set => nodeYes = value; }
        internal Node NodeNo { get => nodeNo; set => nodeNo = value; }

        public void ProcessNode()
        {
            if (isQuestion())
            {
                Console.WriteLine(content);
                char answer = GetAnswer();
                if (answer == 's')
                {
                    nodeYes.ProcessNode();
                }
                else
                {
                    nodeNo.ProcessNode();
                }
            }
            else
            {
                PresentAnswer();
            }
        }

        private static char GetAnswer()
        {
            Console.WriteLine("Digite 's' para sim ou 'n' para não:");
            char answer = Console.ReadLine()[0];
            return answer;
        }

        private void PresentAnswer()
        {
            Console.WriteLine($"Por acaso, você pensou em {content}?");
            char answer = GetAnswer();
            if (answer == 's')
            {
                Console.WriteLine("Opa!!! Parece que acertei!!!");
            } else
            {
                Console.WriteLine("Poxa... Não consegui acertar...");
                Console.WriteLine("Mas, no que você estava pensando??");
                String correctAnswer = Console.ReadLine();
                Console.WriteLine($"Qual seria uma questão para diferenciar {correctAnswer} de {content}");
                String newQuestion = Console.ReadLine();
                Console.WriteLine($"Se você estiver pensando em {correctAnswer}, qual seria a resposta?");
                char newAnswer = GetAnswer();
                Console.WriteLine("Obrigado por colaborar com meu conhecimento!!!");
                if (newAnswer == 's')
                {
                    nodeYes = new Node(correctAnswer);
                    nodeNo = new Node(content);
                } else
                {
                    nodeNo = new Node(correctAnswer);
                    nodeYes = new Node(content);
                }
                content = newQuestion;
            }
        }

        private bool isQuestion()
        {
            if (nodeNo !=null && nodeYes != null)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
