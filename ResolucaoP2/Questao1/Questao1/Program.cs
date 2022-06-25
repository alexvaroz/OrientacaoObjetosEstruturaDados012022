﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        /* 
         * Crie um método que apresente a relação de palavras distintas de um texto 
         * que possuam somente 4 letras. Para o teste, execute o método sobre o texto a seguir: 
         */

        static void Main(string[] args)
        {
            string texto =
                " O termo “gamificação” é proveniente do inglês “gamification”. Como você " +
                "pode imaginar, esse tipo de estratégia tem como base o uso de características " +
                "provenientes dos games.Saiba mais sobre o conceito de gamificação e como ela " +
                "aumenta o engajamento de colaboradores e clientes.Portanto, a gamificação utiliza " +
                "mecanismos como desafios, pontuações, regras, premiações, fases, recompensas e " +
                "tudo o que você pode relacionar ao universo dos jogos, porém aplicada em outros " +
                "contextos, como a educação e, é claro, o mundo empresarial.";

            List<string> relacaoPalavrasComQuatroLetras = ListarPalavrasComQuatroLetrasEmTexto(texto);
            Console.WriteLine($" O texto possui {relacaoPalavrasComQuatroLetras.Count} palvras com 4 letras.");
            foreach (var item in relacaoPalavrasComQuatroLetras)
            {
                Console.Write($"{item}    ");
            }
            Console.ReadLine();

        }

        static List<string> ListarPalavrasComQuatroLetrasEmTexto(string texto)
        {
            HashSet<string> relacaoPalavras = new HashSet<string>();

            string[] palavras = texto.Split(' ', ',', '.', '"');
            foreach (var item in palavras)
            {
                if (item.Length == 4)
                {
                    relacaoPalavras.Add(item.ToLower());
                }
            }
            return relacaoPalavras.ToList();
        }
    }
}
