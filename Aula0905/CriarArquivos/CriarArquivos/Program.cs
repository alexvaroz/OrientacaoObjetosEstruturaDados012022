using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            String arquivoContatos = LoadConfig();
            StreamWriter writer = new StreamWriter(arquivoContatos);
            writer.WriteLine("Bob Nelson,9999-9999,01/01/1981");
            writer.WriteLine("Testolfo Rocha,8888-1234,01/04/1999");
            writer.WriteLine("Testinho Junior,7777-9988,12/12/2010");
            writer.Close();

            List<Contato> meusContatos = new List<Contato>();
            StreamReader reader = new StreamReader(arquivoContatos);
            String contatoStr;
            while ((contatoStr = reader.ReadLine()) != null)
            {
                string[] contatoArray = contatoStr.Split(',');
                Contato contato = new Contato(
                    contatoArray[0],
                    contatoArray[1],
                    contatoArray[2]);
                meusContatos.Add(contato);
            }
            reader.Close();

            Console.WriteLine("Meus contatos são:");
            foreach(Contato item in meusContatos)
            {
                Console.WriteLine($"{item.Nome} tem {item.GetIdade()} anos");
            }

            Console.ReadLine();
            Console.WriteLine("Adicionar novo registro");
            Console.ReadLine();
            string novoContatoStr=String.Empty;
            Console.WriteLine("Insira o nome do contato");
            novoContatoStr += Console.ReadLine()+",";
            Console.WriteLine("Insira o telefone do contato");
            novoContatoStr += Console.ReadLine() + ",";
            Console.WriteLine("Insira a data de nascimento do contato");
            novoContatoStr += Console.ReadLine();
            writer = new StreamWriter(arquivoContatos, append:true);
            writer.WriteLine(novoContatoStr);
            writer.Close();
        }

        private static string LoadConfig()
        {
            String diretorioRaizConfig = Directory.GetParent(
                Directory.GetCurrentDirectory()).
                Parent.FullName;
            var pastaConfig = Path.Combine(diretorioRaizConfig, "Config");
            if (!Directory.Exists(pastaConfig))
            {
                Directory.CreateDirectory(pastaConfig);
            }
            String nomeArquivo = "contatos.txt";
            String arquivoContatos = Path.Combine(pastaConfig, nomeArquivo);
            if (!File.Exists(arquivoContatos))
            {
                File.Create(Path.Combine(pastaConfig, nomeArquivo));
            }
            return arquivoContatos;
        }

        
    }
}
