using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class CalculadoraGeometrica
    {
        public void AceptarFigura(FiguraGeometrica[] pFiguras)
        {
            for (int i = 0; i < pFiguras.Length; i++)
            {
                Console.WriteLine($"Perimetro = {pFiguras[i].CalcularPerimetro()}, Area = {pFiguras[i].CalcularArea()}");
            }
        }
    }
}
