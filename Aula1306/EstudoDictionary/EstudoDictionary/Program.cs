using System;
using System.Collections.Generic;

namespace EstudoDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitalPeloPais = new Dictionary<string, string>();
            capitalPeloPais["Brasil"] = "Brasília";
            capitalPeloPais["Argentina"] = "Buenos Aires";
            capitalPeloPais["Itália"] = "Roma";

            Console.WriteLine($"A capital da Itália é {capitalPeloPais["Itália"]}");
            Console.WriteLine($"A capital do Brasil é {capitalPeloPais["Brasil"]}");
            Console.ReadLine();
        }
    }
}
