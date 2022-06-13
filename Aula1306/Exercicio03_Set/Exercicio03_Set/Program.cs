using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoEntrada = "Vento, ventania " +
           "Me leve para as bordas do céu " +
           "Pois vou puxar as barbas de Deus " +
           "Vento ventania " +
           "Me leve pra onde nasce a chuva " +
           "Pra lá de onde o vento faz a curva " +
           "Me deixe cavalgar nos seus desatinos " +
           "Nas revoadas, redemoinhos " +
           "Vento, ventania " +
           "Me leve sem destino";

            HashSet<String> setPalavras = new HashSet<String>();
            List<String> listaPalavras = new List<String>();
            String[] palavras = textoEntrada.Split(',', ' ');
            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Length > 0)
                {
                    setPalavras.Add(palavras[i].ToLower());
                    listaPalavras.Add(palavras[i].ToLower());
                }
            }
            Console.WriteLine($"Existem {setPalavras.Count} palavras diferentes no texto.");
            Console.WriteLine($"Total de {listaPalavras.Count} palavras.");
            Console.ReadLine();
        }
    }
}
