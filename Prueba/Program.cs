using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Presentación
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona;
            Vehiculo vehiculo;

            Cliente cliente = new Cliente("Junior", "Rodriguez", "1234567890", "3015159004");
            Mecanico mecanico = new Mecanico("Juliana", "Torres", "0987654321", "Supervisora", "Juliana123");

            Bicicleta bicicleta = new Bicicleta("Specialized", "G3", "Negro", "Pintada", 120000);
            Moto moto = new Moto("Boxer", "XZ", "Verde", "Frenos", 50700, "G73 - ABC");
            Auto carro = new Carro("Toyota", "2012", "Blanco", "Cambios", 130460, "DBA -74S");

            Console.WriteLine("PRUEBA ENTIDAD PERSONA");
            persona = cliente;
            Console.WriteLine(persona.ToString());
            Console.WriteLine("------------------------------------------------------------------------");

            persona = mecanico;
            Console.WriteLine(persona.ToString());
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("PRUEBA ENTIDAD VEHICULO");
            vehiculo = bicicleta;
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine("------------------------------------------------------------------------");

            vehiculo = moto;
            Console.WriteLine(vehiculo.ToString());
            Console.WriteLine("------------------------------------------------------------------------");

            vehiculo = carro;
            Console.WriteLine(vehiculo.ToString());
            Console.ReadKey();



        }
    }
}
