using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string diretorio =
                @"C:\Users\201354\Documents\arquivos\novoDiretorio\";
            string nomeArquivo = "meuPrimeiroArquivo.txt";

            if (File.Exists(diretorio + nomeArquivo))
            {
                Console.WriteLine("Arquivo já existente...");
            } else
            {
                Stream arquivo = File.Create(diretorio + nomeArquivo);
                arquivo.Close();
            }
            string novoDiretorio =
               @"C:\Users\201354\Documents\arquivos\ranking";
            Directory.CreateDirectory(novoDiretorio);

        }
    }
}
