using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class ColaFIFO : IColaAtencion
    {
        private static PacienteNulo cPacienteNulo = new PacienteNulo();

        private Queue<Paciente> _cola = new Queue<Paciente>();

        /// <summary>
        /// Crea una nueva instancia de la clase ColaFIFO.
        /// </summary>
        public ColaFIFO() { }

        /// <summary>
        /// Coloca el Paciente que se pasa como parámetro al final de la cola.
        /// </summary>
        /// <param name="pPaciente">Paciente que se agregará al final de la cola.</param>
        public void Admitir(Paciente pPaciente)
        {
            this._cola.Enqueue(pPaciente);
        }

        /// <summary>
        /// Remueve y retorna el Paciente que se encuentra al comienzo de la cola.
        /// </summary>
        /// <returns>Retorna un Paciente o un PacienteNulo si la cola está vacía.</returns>
        public Paciente Atender()
        {
            if (Vacia)
            {
                return cPacienteNulo;
            }
            else
            {
                return this._cola.Dequeue();
            }
        }

        /// <summary>
        /// Retorna true si la cola está vacía, y false si la cola contiene elementos.
        /// </summary>
        public bool Vacia
        {
            get { return this._cola.Count == 0; }
        }
    }
}
