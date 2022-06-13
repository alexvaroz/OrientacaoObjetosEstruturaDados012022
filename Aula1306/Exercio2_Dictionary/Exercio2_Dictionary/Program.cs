using System;
using System.Collections.Generic;

namespace Exercio2_Dictionary
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
            string[] palavras = textoEntrada.Split(' ', ',', '!', '.');
            SortedDictionary<string, int> quantidadePorPalavra = 
                GerarDicionarioOrdenadoQuantidadePorPalavra(palavras);
            foreach (var item in quantidadePorPalavra)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static Dictionary<string, int> GerarDicionarioQuantidadePorPalavra(string[] palavras)
        {
            Dictionary<String, int> quantidadePorPalavra = new Dictionary<string, int>();
            foreach (var item in palavras)
            {
                int quantidade;
                if (item.Length > 0)
                {
                    if (!quantidadePorPalavra.TryGetValue(item.ToLower(), out quantidade))
                    {
                        quantidade = 0;
                    }
                    quantidadePorPalavra[item.ToLower()] = quantidade + 1;
                }
            }

            return quantidadePorPalavra;
        }

        private static SortedDictionary<string, int> GerarDicionarioOrdenadoQuantidadePorPalavra(string[] palavras)
        {
            SortedDictionary<String, int> quantidadePorPalavra = new SortedDictionary<string, int>();
            foreach (var item in palavras)
            {
                int quantidade;
                if (item.Length > 0)
                {
                    if (!quantidadePorPalavra.TryGetValue(item.ToLower(), out quantidade))
                    {
                        quantidade = 0;
                    }
                    quantidadePorPalavra[item.ToLower()] = quantidade + 1;
                }
            }

            return quantidadePorPalavra;
        }


    }
}
