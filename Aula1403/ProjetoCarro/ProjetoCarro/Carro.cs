using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarro
{
    class Carro
    //Cor, Ano de fabricação, Modelo, VelocidadeAtual e VelocidadeMáxima, Ligado/Desligado.

    {
        public String cor;
        public int anoFabricacao;
        public String modelo;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public Boolean estaLigado;

        public Carro(String _cor, int _anoFabricacao, 
                    String _modelo, float _velocidadeMaxima)
        {
            cor = _cor;
            anoFabricacao = _anoFabricacao;
            modelo = _modelo;
            velocidadeMaxima = _velocidadeMaxima;
            velocidadeAtual = 0;
            estaLigado = false;
        }

      public void Ligar()
        {
            if (!estaLigado)
            {
                estaLigado = true;
                Console.WriteLine("Carro foi ligado!");
            } else
            {
                Console.WriteLine("Carro já está ligado!");
            }
        }

      


    }
}
