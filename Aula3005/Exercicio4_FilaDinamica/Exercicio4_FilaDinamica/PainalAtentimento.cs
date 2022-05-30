using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4_FilaDinamica
{
    class PainelAtentimento
    {
        FilaDinamica filaSenhas;
        int ultimaSenhaAtendida;
        List<int> listaSenhasGeradas;

        public PainelAtentimento()
        {
            this.filaSenhas = new FilaDinamica();
            this.ultimaSenhaAtendida = -1;
            this.listaSenhasGeradas = new List<int>();
        }

        public int GerarSenha()
        {
            Random rnd = new Random();
            Boolean senhaJaFoiUtilizada = false;
            int senhaGerada;
            do
            {
                senhaGerada = rnd.Next(0, 1000);
                if (listaSenhasGeradas.Contains(senhaGerada))
                {
                    senhaJaFoiUtilizada = true;
                } else
                {
                    listaSenhasGeradas.Add(senhaGerada);
                    filaSenhas.Enqueue(senhaGerada);
                    senhaJaFoiUtilizada = false;
                }               
            } while (senhaJaFoiUtilizada);
            return senhaGerada;
        }

        public int ChamarSenha()
        {
            return (int) filaSenhas.Peek();
        }
        
        public void AtenderSenha()
        {
            ultimaSenhaAtendida = (int) filaSenhas.Peek();
            filaSenhas.Dequeue();
        }  

        public void MostrarListaEspera()
        {
            filaSenhas.ShowQueueElements();
        }

        public void MostrarUltimaSenhaAtendida()
        {
            Console.WriteLine(ultimaSenhaAtendida);
        }
        
    }
}
