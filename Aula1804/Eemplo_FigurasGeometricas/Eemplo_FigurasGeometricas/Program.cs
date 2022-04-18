using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eemplo_FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo = new Circulo(10);
            Triangulo triangulo = new Triangulo(10);
            Quadrado quadrado = new Quadrado(10);
            Hexagono hexagono = new Hexagono(10);

            Console.WriteLine("Circulo");
            Console.WriteLine($"Área: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {circulo.CalcularPerimetro()}");
            Console.WriteLine("Triangulo");
            Console.WriteLine($"Área: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {triangulo.CalcularPerimetro()}");
            Console.WriteLine("Quadrado");
            Console.WriteLine($"Área: {quadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro: {quadrado.CalcularPerimetro()}");
            Console.WriteLine("Hexagono");
            Console.WriteLine($"Área: {hexagono.CalcularArea()}");
            Console.WriteLine($"Perímetro: {hexagono.CalcularPerimetro()}");
            Console.ReadLine();


        }
    }
}
