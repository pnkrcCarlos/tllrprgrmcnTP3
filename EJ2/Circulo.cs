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

        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Punto Centro
        {
            get { return this.iCentro; }
        }

        public double Radio
        {
            get { return this.iRadio; }
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.Radio;
        }

        public override double CalcularArea()
        {
            return Math.Pow(this.Radio, 2) * Math.PI;
        }
    }
}
