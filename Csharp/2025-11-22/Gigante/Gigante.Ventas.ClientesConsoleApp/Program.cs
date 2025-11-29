using Gigante.Ventas.Domain;
using System;

// SOLID
// 1. Single Responsibility Principle
// 2. Open/Closed Principle
// 3. Liskov's Substitution Principle
//    Teorema que dice: A = B y B = C, entonces A = C
// 4. Interface Segregation Principle
// 5. Dependency Inversion Principle


namespace Gigante.Ventas.ClientesConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clientes clientes = new Clientes();
            PagosEfectivo pagosEfectivo = new PagosEfectivo();

            pagosEfectivo.PagoEfectivoId = 100;

        }

        public Program()
        {
            
        }
    }
}
