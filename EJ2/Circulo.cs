using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Circulo : FiguraGeometrica
    {
        private Punto iCentro;
        private double iRadio;

        /// <summary>
        /// Inicializa una nueva instancia de la clase Circulo con valores de centro y radio indicados como parámetros.
        /// </summary>
        /// <param name="pCentro">Punto céntrico del círculo.</param>
        /// <param name="pRadio">Radio del círculo.</param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        /// <summary>
        /// Devuelve el Punto céntrico del círculo.
        /// </summary>
        public Punto Centro
        {
            get { return this.iCentro; }
        }

        /// <summary>
        /// Devuelve el radio del círculo.
        /// </summary>
        public double Radio
        {
            get { return this.iRadio; }
        }

        /// <summary>
        /// Devuelve el perímetro del círculo.
        /// </summary>
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }

        /// <summary>
        /// Devuelve el área del círculo.
        /// </summary>
        public override double CalcularArea()
        {
            return Math.Pow(this.Radio, 2) * Math.PI;
        }
    }
}
