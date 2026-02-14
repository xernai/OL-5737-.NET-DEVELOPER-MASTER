using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace Clase02Csharp
{
    public delegate int CalcularSueldos(int sueldoBase);
    class Persona
    {
        public int ID { get; set; } // propiedad automática
        public string Name { get; set; }


        // overloading es una especie de polimorfismo
        public Persona()
        {

        }

        public Persona(int id, string name)
        {
            ID = id;
            Name = name;
        }

         public int CalcularSueldo()
        {
            int sueldo = 1000;
            return sueldo;
        }
    }

    class Paciente : Persona
    {
        private string Enfermedad { get; set; }
        private string Alergia { get; set; }
        private string Email { get; set; }

        
        public int HistorialClinico { get; set; }



        public Paciente()
        {

        }

        public Paciente(int id, string name) : base(id, name)
        {

        }

        public Paciente(int id, string name, string email) : this(name, email)
        {
            // TODO
        }

        public Paciente(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string GetEmail()
        {
            return Name + " " + Email;
        }

        public void GetEmail(string name, string email)
        {
          
        }

        public string DarReceta()
        {
            return "Tomar Paracetamol cada 8 horas por 5 días";
        }

        public int CalcularSueldo(int x)
        {
            return x + 10;
        }

        public int CalcularSueldo1(string y)
        {
            return 4;
        }
        
         public int CalcularSueldo2(int y)
        {
            return y;
        }
    }

    class Proveedor : Persona
    {

    }
    
    class Contribuyente : Persona
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(1, "Manuel");
    

            Paciente paciente1 = new Paciente();
            Console.WriteLine($"Paciente 1: ID = {paciente1.ID}, Name = {paciente1.Name}");

            Paciente paciente2 = new Paciente(2, "Ana Gomez");
            Console.WriteLine($"Paciente 2: ID = {paciente2.ID}, Name = {paciente2.Name}");

            string resultado = paciente1.DarReceta();
            Console.WriteLine(resultado);

            Paciente paciente3 = new Paciente(1, "Luis Perez", "example@gmail.com");

            var formatoEmail = paciente3.GetEmail();

            Console.WriteLine(formatoEmail);

            //var sueldo = paciente3.CalcularSueldo();
            //Console.WriteLine($"Sueldo Paciente 3: {sueldo}");

            // 
            CalcularSueldos calcularSueldosDelegate = new CalcularSueldos(paciente3.CalcularSueldo);

            calcularSueldosDelegate += paciente3.CalcularSueldo2;

            var sueldo1 = calcularSueldosDelegate(1000); //  paciente3.CalcularSueldo();
            Console.WriteLine($"Sueldo Paciente 3: {sueldo1}");

            calcularSueldosDelegate -= paciente3.CalcularSueldo;
            calcularSueldosDelegate -= paciente3.CalcularSueldo2;

            // Func, Action, Predicate
            
        }
    }
}

 