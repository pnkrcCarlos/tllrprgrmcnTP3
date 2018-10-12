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

        public Encriptador(String pNombre)
        {
            this.iNombre = pNombre;
        }

        public abstract String Encriptar(String pString);

        public abstract String Desencriptar(String pString);

    }
}