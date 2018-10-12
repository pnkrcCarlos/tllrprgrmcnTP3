using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Triangulo : FiguraGeometrica
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Triangulo con los puntos que lo definen indicados por los parámetros.
        /// </summary>
        /// <param name="pA">Punto 1 (A) del triángulo.</param>
        /// <param name="pB">Punto 2 (B) del triángulo.</param>
        /// <param name="pC">Punto 3 (C) del triángulo.</param>
        public Triangulo(Punto pA, Punto pB, Punto pC)
        {
            this.iPunto1 = pA;
            this.iPunto2 = pB;
            this.iPunto3 = pC;
        }

        /// <summary>
        /// Devuelve el punto 1 (A) del triángulo.
        /// </summary>
        public Punto Punto1 // A
        {
            get { return this.iPunto1; }
        }

        /// <summary>
        /// Devuelve el punto 2 (B) del triángulo.
        /// </summary>
        public Punto Punto2 // B
        {
            get { return this.iPunto2; }
        }

        /// <summary>
        /// Devuelve el punto 3 (C) del triángulo.
        /// </summary>
        public Punto Punto3 // C
        {
            get { return this.iPunto3; }
        }

        private double LadoA // a
        {
            get { return this.Punto2.CalcularDistanciaDesde(this.Punto3); }
        }

        private double LadoB // b
        {
            get { return this.Punto1.CalcularDistanciaDesde(this.Punto3); }
        }

        private double LadoC // c
        {
            get { return this.Punto1.CalcularDistanciaDesde(this.Punto2); }
        }

        /// <summary>
        /// Devuelve perímetro del triángulo.
        /// </summary>
        public override double CalcularPerimetro()
        {
            return this.LadoA + this.LadoB + this.LadoC;
        }

        /// <summary>
        /// Devuelve el área del triángulo.
        /// </summary>
        public override double CalcularArea()
        {
            double s = this.CalcularPerimetro() / 2;
            return Math.Sqrt(s * (s - this.LadoA) * (s - this.LadoB) * (s - this.LadoC));
        }
    }
}
