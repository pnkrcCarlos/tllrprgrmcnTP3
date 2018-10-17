using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class FabricaEncriptadores
    {
        private static EncriptadorNulo cEncriptadorNulo = new EncriptadorNulo();

        private static FabricaEncriptadores cInstancia;

        private Dictionary<String, IEncriptador> iEncriptadores = new Dictionary<String, IEncriptador>();

        private FabricaEncriptadores()
        {
            this.iEncriptadores.Add("César", new EncriptadorCesar(14));
            this.iEncriptadores.Add("AES", new EncriptadorAES());
            // dos más
        }

        /// <summary>
        /// Retorna el encriptador correspondiente al código pasado como parámetro.
        /// </summary>
        /// <param name="pString">Código identificador del encriptador.</param>
        /// <returns>IEncriptador.</returns>
        public IEncriptador GetEncriptador(String pString)
        {
            if (this.iEncriptadores.ContainsKey(pString))
            {
                return this.iEncriptadores[pString];
            }
            else
            {
                return cEncriptadorNulo;
            }
        }

        /// <summary>
        /// Retorna la instancia de FabricaEncriptadores.
        /// </summary>
        public static FabricaEncriptadores Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    cInstancia = new FabricaEncriptadores();
                }
                return cInstancia;
            }
        }
    }
}
