using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EncriptadorCesar : Encriptador
    {
        private int iDesplazamiento;

        /// <summary>
        /// Crea una nueva instancia de EncriptadorCesar con el desplazamiento indicado como parámetro.
        /// </summary>
        /// <param name="pDesplazamiento">Desplazamiento utilizado para el cifrado.</param>
        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de encriptar la cadena pasada como parámetro usando cifrado César.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public override String Encriptar(String pString)
        {
            char[] palabra = pString.ToCharArray();
            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];
                letra = (char)(letra + this.iDesplazamiento);
                if (letra > '~')
                {
                    letra = (char)(letra - 95);
                }
                else if (letra < ' ')
                {
                    letra = (char)(letra + 95);
                }
                palabra[i] = letra;
            }
            return new String(palabra);
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de desencriptar la cadena pasada como parámetro usando cifrado César.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public override String Desencriptar(String pString)
        {
            char[] palabra = pString.ToCharArray();
            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i];
                letra = (char)(letra - this.iDesplazamiento);
                if (letra > '~')
                {
                    letra = (char)(letra - 95);
                }
                else if (letra < ' ')
                {
                    letra = (char)(letra + 95);
                }
                palabra[i] = letra;
            }
            return new String(palabra);
        }
    }
}
