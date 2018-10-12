using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Veterinaria
    {
        public void AceptarAnimales(Animal[] pAnimales)
        {
            for (int i = 0; i < pAnimales.Length; i++)
            {
                pAnimales[i].HacerRuido();
            }
        }
    }
}
