using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarArquivos
{
    class Contato
    {
        string nome;
        string telefone;
        string dataNascimento;

        public Contato(string nome, string telefone, string dataNascimento)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.dataNascimento = dataNascimento;
        }

        public string Nome
        {
            get
            {
                return nome;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

        }

        public string DataNascimento
        {
            get
            {
                return dataNascimento;
            }
        }

        public int GetIdade()
        {
            DateTime hoje = DateTime.Today;
            String[] dataNascimentoStr = dataNascimento.Split('/');
            DateTime dataNascimentoDt = new DateTime(
                int.Parse(dataNascimentoStr[2]),
                int.Parse(dataNascimentoStr[1]),
                int.Parse(dataNascimentoStr[0]));
            int idade = hoje.Year - dataNascimentoDt.Year;
            if (hoje.DayOfYear < dataNascimentoDt.DayOfYear)
            {
                idade--;
            }
            return idade;

                   }
    }
}
