using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TP3/EJ2");
            FiguraGeometrica[] figuras = new FiguraGeometrica[] { new Circulo(new Punto(0, 0), 14), new Triangulo(new Punto(0, 0), new Punto(1, 0), new Punto(0, 1)) };
            CalculadoraGeometrica calculadora = new CalculadoraGeometrica();
            calculadora.AceptarFigura(figuras);
            Console.ReadKey();
        }
    }
}
