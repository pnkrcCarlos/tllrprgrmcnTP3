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

        public EncriptadorCesar(int pDesplazamiento) : base("César")
        {
            this.iDesplazamiento = pDesplazamiento;
        }

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
