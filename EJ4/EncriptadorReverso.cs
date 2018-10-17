using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorReverso : Encriptador
    {
        /// <summary>
        /// Crea una nueva instancia de EncriptadorReverso.
        /// </summary>
        public EncriptadorReverso() : base("Reverso") { }

        /// <summary>
        /// Retorna la cadena que se obtiene de invertir el orden de los caracteres de la cadena pasada como parámetro.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public override String Encriptar(String pString)
        {
            return Invertir(pString);
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de invertir el orden de los caracteres de la cadena pasada como parámetro.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public override String Desencriptar(String pString)
        {
            return Invertir(pString);
        }

        private static String Invertir(String pCadena)
        {
            char[] arreglo = pCadena.ToCharArray(); // Convierto la cadena a un array para usar Reverse
            Array.Reverse(arreglo);
            return new string(arreglo);
        }
    }
}
