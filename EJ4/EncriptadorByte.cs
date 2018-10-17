using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class EncriptadorByte : Encriptador
    {
        public EncriptadorByte() : base("Byte") { }

        /// <summary>
        /// Retorna la representación en Base64 del array formado por los bytes correspondientes a cada caracter de la cadena pasada como parámetro.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public override String Encriptar(String pString)
        {
            char[] palabra = pString.ToCharArray();
            List<byte> encriptada = new List<byte>();
            for (int i = 0; i < palabra.Length; i++)
            {
                encriptada.Add((byte)palabra[i]);
            }
            return Convert.ToBase64String(encriptada.ToArray<byte>());
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de usar el EncriptadorByte.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public override String Desencriptar(String pString)
        {
            byte[] encriptada = Convert.FromBase64String(pString);
            List<char> desencriptada = new List<char>();
            for (int i = 0; i < encriptada.Length; i++)
            {
                desencriptada.Add((char)encriptada[i]);
            }
            return new String(desencriptada.ToArray<char>());
        }
    }
}
