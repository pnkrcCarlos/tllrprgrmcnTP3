using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public sealed class EncriptadorNulo : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorNulo() : base("Null") { }

        public override String Encriptar(String pString)
        {
            return pString;
        }

        public override String Desencriptar(String pString)
        {
            return pString;
        }
    }
}
