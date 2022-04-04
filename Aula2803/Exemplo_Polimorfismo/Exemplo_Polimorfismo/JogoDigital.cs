using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Polimorfismo
{
    class JogoDigital : Produto
    {
        private String fabricante;
        private String titulo;
        private String console;

        public JogoDigital(string fabricante, 
            string titulo, string console, float preco):base(preco)
        {
            this.fabricante = fabricante;
            this.titulo = titulo;
            this.console = console;
        }

        public string Fabricante
        {
            get
            {
                return fabricante;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }
        }

        public string Console
        {
            get
            {
                return console;
            }
        }

        public override String InformarDescricao()
        {
            return $"{this.titulo} - {this.console} - {this.fabricante}";
        }
    }
}
