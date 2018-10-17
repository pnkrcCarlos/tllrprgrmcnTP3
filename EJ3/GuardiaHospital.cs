using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class GuardiaHospital // Controlador
    {
        private static ColaFIFO cFifo = new ColaFIFO();
        private static ColaTriaje cTriaje = new ColaTriaje();

        /// <summary>
        /// Coloca el Paciente que se pasa como parámetro al final de una ColaFIFO.
        /// </summary>
        /// <param name="pPaciente">Paciente que se agregará al final de la ColaFIFO.</param>
        public void Admitir(Paciente pPaciente)
        {
            cFifo.Admitir(pPaciente);
        }

        /// <summary>
        /// Coloca el Paciente que se pasa como parámetro en una ColaTriaje según la Prioridad que se pasa como parámetro.
        /// </summary>
        /// <param name="pPaciente">Paciente que se agregará a la ColaTriaje.</param>
        /// <param name="pPrioridad">Prioridad con la que se agregará a pPaciente en la ColaTriaje</param>
        public void Admitir(Paciente pPaciente, Prioridad pPrioridad)
        {
            cTriaje.Prioridad = pPrioridad;
            cTriaje.Admitir(pPaciente);
        }

        /// <summary>
        /// Remueve y retorna el Paciente que se encuentra al comienzo de la cola de mayor prioridad (ColaTriaje), o al comienzo de la ColaFIFO.
        /// </summary>
        /// <param name="pTipoCola">Cadena que representa al tipo de cola de la que se removerá el Paciente.</param>
        /// <returns>Retorna un Paciente o un PacienteNulo si la cola está vacía.</returns>
        public Paciente Atender(String pTipoCola)
        {
            switch (pTipoCola)
            {
                case "fifo":
                    return cFifo.Atender();
                case "triaje":
                    return cTriaje.Atender();
                default:
                    throw new ArgumentException("pTipoCola");
            }
        }
    }
}
