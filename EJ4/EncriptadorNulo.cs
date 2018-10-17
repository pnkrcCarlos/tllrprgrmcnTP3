using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public sealed class EncriptadorNulo : Encriptador
    {
        /// <summary>
        /// Crea una nueva instancia de EncriptadorNulo.
        /// </summary>
        public EncriptadorNulo() : base("Null") { }

        /// <summary>
        /// Retorna la cadena original.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public override String Encriptar(String pString)
        {
            return pString;
        }

        /// <summary>
        /// Retorna la cadena original.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public override String Desencriptar(String pString)
        {
            return pString;
        }
    }
}
