using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TP3/EJ1");
            Animal[] animales = new Animal[] { new Perro(), new Gato() };
            Veterinaria veterinaria = new Veterinaria();
            veterinaria.AceptarAnimales(animales);
            Console.ReadKey();
        }
    }
}
