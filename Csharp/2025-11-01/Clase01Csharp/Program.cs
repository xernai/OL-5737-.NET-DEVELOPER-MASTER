using System;

namespace Clase01Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            short edad = 20;
            Console.WriteLine($"{edad}");

            PrintEdad(edad);

            edad = 50;

            Console.WriteLine($"{edad}");

            // lambda expressions:
            //   1. expression lambda - una sola linea
            //   2. statement lambda - varias lineas


            // string por referencia
            string nombre = "Juan"; // stack queda una dir de memoria a la heap es la 1000
            string nombre1 = "Manuel"; // stack queda una dir de memoria a la heap

            Console.WriteLine($"variable nombre {nombre}");
            Console.WriteLine($"variable nombre1 {nombre1}");

            nombre1 = nombre; // nombre y nombre1 apuntan a la direccion 1000

            Console.WriteLine($"variable despues nombre {nombre}");
            Console.WriteLine($"variable despues nombre1 {nombre1}");
        }


        private static void PrintEdad(short edad)
        {
            Console.WriteLine($" Edad antes cuando llega al m'e {edad}");
            edad = 40;
            Console.WriteLine($" Edad despues cuando llega al m'e {edad}");
        }
    }
}
