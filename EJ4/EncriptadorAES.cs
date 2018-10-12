using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    public class EncriptadorAES : Encriptador
    {
        private int iDesplazamiento;

        public EncriptadorAES() : base("AES") { }

        public override String Encriptar(String pString)
        {
            throw new NotImplementedException();
        }

        public override String Desencriptar(String pString)
        {
            throw new NotImplementedException();
        }
    }
}
