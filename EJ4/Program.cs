using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TP3/EJ4");

            char input = new char();
            ControladorEncriptadores ctrlEncriptadores = new ControladorEncriptadores();

            Console.WriteLine();
            Console.Write("Palabra: ");
            String palabra = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Encriptador:");
            Console.WriteLine("[ 1 ] César");
            Console.WriteLine("[ 2 ] AES");
            Console.WriteLine("[ 3 ] Otro 1");
            Console.WriteLine("[ 4 ] Otro 2");
            Console.WriteLine("[Esc] Salir");
            do
            {
                if (palabra.Length == 0) {
                    break;
                }
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && (ConsoleKey)input != ConsoleKey.D1 && (ConsoleKey)input != ConsoleKey.D2 && (ConsoleKey)input != ConsoleKey.D3 && (ConsoleKey)input != ConsoleKey.D4);

            String encriptador = "";

            if (palabra.Length > 0)
            {
                switch (input)
                {
                    case '1':
                        encriptador = "César";
                        break;
                    case '2':
                        encriptador = "AES";
                        break;
                    default:
                        encriptador = "lalalalala";
                        break;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Operación:");
            Console.WriteLine("[ 1 ] Encriptar");
            Console.WriteLine("[ 2 ] Desencriptar");
            Console.WriteLine("[Esc] Salir");
            do
            {
                if (palabra.Length == 0)
                {
                    break;
                }
                input = Console.ReadKey().KeyChar;
            } while ((ConsoleKey)input != ConsoleKey.Escape && (ConsoleKey)input != ConsoleKey.D1 && (ConsoleKey)input != ConsoleKey.D2);

            Console.WriteLine();
            switch (input)
            {
                case '1':
                    Console.WriteLine(ctrlEncriptadores.Encriptar(encriptador, palabra));
                    break;
                case '2':
                    Console.WriteLine(ctrlEncriptadores.Desencriptar(encriptador, palabra));
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
