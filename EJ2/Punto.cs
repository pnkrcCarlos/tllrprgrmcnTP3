using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Punto
    {
        private double iX;
        private double iY;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Punto con las componentes indicadas por los parámetros.
        /// </summary>
        /// <param name="pX">Componente en X.</param>
        /// <param name="pY">Componente en Y.</param>
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        /// <summary>
        /// Devuelve la componente en X del punto.
        /// </summary>
        public double X
        {
            get { return this.iX; }
        }

        /// <summary>
        /// Devuelve la componente en Y del punto.
        /// </summary>
        public double Y
        {
            get { return this.iY; }
        }

        /// <summary>
        /// Devuelve la distancia entre este punto y el punto pasado como parámetro.
        /// </summary>
        /// <param name="pPunto">Punto desde el cual se calculará la distancia hacia el punto actual.</param>
        /// <returns></returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.X - pPunto.X, 2) + Math.Pow(this.Y - pPunto.Y, 2));
        }

    }
}
