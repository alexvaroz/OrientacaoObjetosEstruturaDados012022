using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarroCompleto
{
    class Carro
    {
        public String cor;
        public String modelo;
        public int anoFabricacao;
        public float velocidadeAtual;
        public float velocidadeMaxima;
        public Boolean estaLigado;

        public Carro(string cor, string modelo, int anoFabricacao, float velocidadeMaxima)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeAtual = 0;
            this.velocidadeMaxima = velocidadeMaxima;
            this.estaLigado = false;
        }

        //Métodos
        public void LigarCarro()
        {
            if (!estaLigado)
            {
                estaLigado = true;
                Console.WriteLine("O carro está ligado!");
            }
            else
            {
                Console.WriteLine("O carro já está ligado!");
            }
        }

        public void Acelerar()
        {
            if (estaLigado)
            {
                if (velocidadeAtual < velocidadeMaxima)
                {
                    velocidadeAtual += 30;
                    if (velocidadeAtual > velocidadeMaxima)
                    {
                        velocidadeAtual = velocidadeMaxima;
                    }
                    Console.WriteLine($"A velocidade atual é {velocidadeAtual}");
                }
                else
                {
                    Console.WriteLine("O carro já está na velocidade máxima");
                }
            }
            else
            {
                Console.WriteLine("O carro está desligado...");
            }
        }
    }
}

