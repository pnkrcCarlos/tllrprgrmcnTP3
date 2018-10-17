using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Paciente
    {
        private String _nombre;
        private int _dni;

        /// <summary>
        /// Crea una nueva instancia de la clase Paciente.
        /// </summary>
        /// <param name="pNombre">Nombre del paciente.</param>
        /// <param name="pDni">DNI del paciente.</param>
        public Paciente(String pNombre, int pDni)
        {
            this._nombre = pNombre;
            this._dni = pDni;
        }

        /// <summary>
        /// Retorna el nombre del paciente.
        /// </summary>
        public String Nombre { get { return this._nombre; } }

        /// <summary>
        /// Retorna el DNI del paciente.
        /// </summary>
        public int DNI { get { return this._dni; } }

    }
}
