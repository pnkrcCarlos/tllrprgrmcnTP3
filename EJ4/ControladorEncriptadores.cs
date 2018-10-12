using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class ControladorEncriptadores
    {
        public String Encriptar(String pEncriptador, String pPalabra)
        {
            FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;
            return fabrica.GetEncriptador(pEncriptador).Encriptar(pPalabra);
        }

        public String Desencriptar(String pEncriptador, String pPalabra)
        {
            FabricaEncriptadores fabrica = FabricaEncriptadores.Instancia;
            return fabrica.GetEncriptador(pEncriptador).Desencriptar(pPalabra);
        }
    }
}
