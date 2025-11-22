using AbarrotesLaMorena.Domain;
using AbarrotesLaMorena.Helper;
using System;
using System.Runtime.Serialization;

namespace AbarrotesLaMorena.ClientesAdmin.ConsoleApp
{
    public delegate int SumValues(int value1, int value2);
    public delegate int HandleValues(int value);
    internal class Program
    {
        static void Main(string[] args)
        {
           Clientes clientes = new Clientes();
           clientes.Id = 1;

           clientes.Nombre = "Juan";
           clientes.Paterno = "Pérez";
           clientes.Materno = "Martínez";

           var resultado = Transformer.FormatName(clientes.Nombre,
                clientes.Paterno, clientes.Materno);

           Console.WriteLine(resultado);

           var profile = SAT.GetProfile();

            // var sumaResultado = Calculadora.Resta2Valores(3, 1);

            // Console.WriteLine($"La suma de 2 valores es:{sumaResultado}");

            //SumValues del1 = delegate(int v1, int v2)
            //                {
            //                    return v1 + v2;
            //                };

            var res0 = Suma2Valores(3, 3);

            SumValues del1 = new SumValues(Suma2Valores);

            var res1 = del1(3, 3);
            Console.WriteLine(res1);

            SumValues del2 = delegate (int x, int z) { return x - z; };

            var res2 = del2(3, 3);
            Console.WriteLine($"Resultado con metodo anonimo: {res2}");

            //----------- lambda expressions
            //            1. Expression lambda -> una sola linea
            //            2. Statement lambda -> varias lineas

            // Paso 1. cambiar delegate por => (goes to)
            SumValues paso1 = (int x, int z) => { return x - z; };

            // Paso 2. quitar return y llaves del cuerpo del metodo
            SumValues paso2 = (int x, int z) => x - z;

            var res3 = paso2(3, 3);

            Console.WriteLine($"Expression Lambda: {res3}");

            // Proceso para llegar a una statement lambda
            SumValues del3 = delegate (int x, int z) 
                            {
                                x = x + 10;
                                return x - z;
                            };

            var res4 = del3(3, 3);

            Console.WriteLine($"Statement Lambda: {res4}");

            // Paso 1. quitar delegate keyword y quitar =>
            SumValues pasoStatement1 =  (int x, int z) =>
            {
                x = x + 10;
                return x - z;
            };

            // Paso 2. 
            SumValues pasoStatement2 = (int x, int z) =>
            {
                x = x + 10;
                return x - z;
            };

            // Paso 3. 
            SumValues pasoStatement3 = (x, z) =>
            {
                x = x + 10;
                return x - z;
            };

            HandleValues handleValues = delegate (int x)
                                        {
                                            x = x + 10;
                                          return x; 
                                        };
            //
            HandleValues handleValues1 = x =>
            {
                x = (int)Math.Sqrt(x);
                return x + 10;
            };

            // Func, Action son delegados en .NET ya nadamas para consumirse
            // Func delegate recibe parametros y regresa algo
            //   ----params----  ---regresa--
            Func<int, int, int,     int>        func1 = delegate(int x, int y, int z)
                                            { 
                                                return x + y + z; 
                                            };

            var resultadoFunc1 = func1(3, 4, 5);

            Console.WriteLine($"Resultado de Func<int, int, int, int> {resultadoFunc1}");

            Func<int, int, int, int, int> func2 = delegate (int x, int y, int w, int z)
            {
                return x + y + z + w;
            };

            var resultadoFunc2 = func2(3, 4, 5, 1);

            Console.WriteLine($"Resultado de Func<int, int, int, int, int> {resultadoFunc2}");

            // Action delegate solo acepta parametros y no regresa nada, es decir se pone void antes del
            // nombre del metodo

            Action action1 = delegate ()
            {
               

                Console.WriteLine($"Hola Mundo");
            };

            Action<int, string> action2 = (int age, string name) =>
            {
                if (age < 18)
                {
                    Console.WriteLine($"No eres candidato a credito: {name}");
                }
                else {
                    Console.WriteLine($"Si eres candidato a credito: {name}");
                }
              
                Console.WriteLine($"Hola Mundo");
            };

            action2(20, "Juan");

            // Se envia un metodo como callback a otro metodo
            Func<int, string> func6 = delegate (int grados)
            {
                return $"Dado que la temperatura es de {grados}, por favor abrigate bien";

                // ADO.NET
                // DB.Insert("xy");
            };

            var notificacion = NotificarTemperatura(12, func6);

            Console.WriteLine(notificacion);
        }

        private static int Suma2Valores(int v1, int v2)
        {
            return v1 + v2;
        }

        static string NotificarTemperatura(int gradosC, Func<int, string> aviso)
        {
            var resultado = "";
            if(gradosC < 14)
            {
               resultado = aviso(gradosC);
            }

            return resultado;
        }

        private static int x01(int v1, int v2)
        {
            return v1 - v2;
        }
    }
}
