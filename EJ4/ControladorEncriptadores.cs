using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class ControladorEncriptadores
    {
        /// <summary>
        /// Encripta la cadena pasada como parámetro utilizando el encriptador que se identifica por el código pasado como parámetro.
        /// </summary>
        /// <param name="pEncriptador">Código identificador del encriptador.</param>
        /// <param name="pPalabra">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public String Encriptar(String pEncriptador, String pPalabra)
        {
            FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;
            return fabrica.GetEncriptador(pEncriptador).Encriptar(pPalabra);
        }

        /// <summary>
        /// Desencripta la cadena pasada como parámetro utilizando el encriptador que se identifica por el código pasado como parámetro.
        /// </summary>
        /// <param name="pEncriptador">Código identificador del encriptador.</param>
        /// <param name="pPalabra">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public String Desencriptar(String pEncriptador, String pPalabra)
        {
            FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;
            return fabrica.GetEncriptador(pEncriptador).Desencriptar(pPalabra);
        }
    }
}
