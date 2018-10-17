using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class ColaTriaje : IColaAtencion
    {
        private static PacienteNulo cPacienteNulo = new PacienteNulo();

        private Dictionary<Prioridad, ColaFIFO> _cola = new Dictionary<Prioridad, ColaFIFO>();
        private Prioridad _prioridad = Prioridad.azul;

        /// <summary>
        /// Crea una nueva instancia de la clase ColaTriaje.
        /// </summary>
        public ColaTriaje()
        {
            this._cola.Add(Prioridad.rojo, new ColaFIFO());
            this._cola.Add(Prioridad.anaranjado, new ColaFIFO());
            this._cola.Add(Prioridad.amarillo, new ColaFIFO());
            this._cola.Add(Prioridad.verde, new ColaFIFO());
            this._cola.Add(Prioridad.azul, new ColaFIFO());
        }

        /// <summary>
        /// Coloca el Paciente que se pasa como parámetro al final de la cola correspondiente a la prioridad actual.
        /// </summary>
        /// <param name="pPaciente">Paciente que se agregará al final de la cola.</param>
        public void Admitir(Paciente pPaciente)
        {
            this._cola[_prioridad].Admitir(pPaciente);
        }

        /// <summary>
        /// Remueve y retorna el Paciente que se encuentra al comienzo de la cola de mayor prioridad.
        /// </summary>
        /// <returns>Retorna un Paciente o un PacienteNulo si la cola está vacía.</returns>
        public Paciente Atender( )
        {
            if (!Vacia)
            {
                for (Prioridad i = Prioridad.rojo; i <= Prioridad.azul; i++)
                {
                    if (!this._cola[i].Vacia)
                    {
                        return this._cola[i].Atender();
                    }
                }
            }
            return cPacienteNulo;
        }

        /// <summary>
        /// Establece la prioridad con la que se admiten a los pacientes.
        /// </summary>
        public Prioridad Prioridad { set { this._prioridad = value; } }

        /// <summary>
        /// Retorna true si la cola está vacía, y false si la cola contiene elementos.
        /// </summary>
        private bool Vacia
        {
            get
            {
                for (Prioridad i = Prioridad.rojo; i <= Prioridad.azul; i++)
                {
                    if (!this._cola[i].Vacia)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
