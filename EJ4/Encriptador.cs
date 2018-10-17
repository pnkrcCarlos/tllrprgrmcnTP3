using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public abstract class Encriptador : IEncriptador
    {
        private readonly String iNombre;

        /// <summary>
        /// Crea una nueva instancia de Encriptador y le da el nombre pasado como parámetro.
        /// </summary>
        /// <param name="pNombre">Nombre del encriptador.</param>
        public Encriptador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de encriptar la cadena pasada como parámetro.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public abstract String Encriptar(String pString);

        /// <summary>
        /// Retorna la cadena que se obtiene de desencriptar la cadena pasada como parámetro.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public abstract String Desencriptar(String pString);

    }
}