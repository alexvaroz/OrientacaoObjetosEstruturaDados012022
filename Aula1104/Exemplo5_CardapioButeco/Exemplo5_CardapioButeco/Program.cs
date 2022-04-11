using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5_CardapioButeco
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemMenu cafe = new Bebida("Café Expresso", 2, 4, 6);
            Console.WriteLine(cafe.InformarNome());
            Console.WriteLine(cafe.InformarPreco());
            ItemMenu batataFrita = new Aperitivo("Porção de Fritas", 25);
            Console.WriteLine(batataFrita.InformarNome());
            Console.WriteLine(batataFrita.InformarPreco());
            Console.ReadLine();
            ItemMenu frangoPassarinho = new Aperitivo("Frango a Passarinho", 40);
            Console.WriteLine(frangoPassarinho.InformarNome());
            Console.WriteLine(frangoPassarinho.InformarPreco());
            Console.ReadLine();


        }
    }
}
