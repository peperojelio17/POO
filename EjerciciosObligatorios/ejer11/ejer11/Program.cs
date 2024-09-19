using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Manuel",31);
            Persona p2 = new Persona("Elian",10);
            Persona p3 = new Persona("Mendoza",3);
            Persona p4 = new Persona("Eugenia",24);
            List<Persona> jugadores = new List<Persona>() { p1,p2,p3,p4};
            AdministradorApuestas admApuestas = new AdministradorApuestas(jugadores, 3);

            Console.WriteLine("Dinero de los jugadores antes de la apuesta:");
            foreach (var a in admApuestas.Jugadores)
                Console.WriteLine($"{a.Nombre}: {a.Dinero}");
            Console.WriteLine();
            Console.WriteLine();
            admApuestas.apuesta();
            Console.WriteLine("Cantidad de veces que acertaron:");
            foreach (var a in admApuestas.aciertos)
            Console.WriteLine($"{a.Key.Nombre}: {a.Value}");
            if (admApuestas.jornadaTermidada)
            {
                Console.WriteLine("Alguien gano más de dos veces");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Dinero de los jugadores despues de la apuesta:");
            foreach (var a in admApuestas.Jugadores)
                Console.WriteLine($"{a.Nombre}: {a.Dinero}");
            Console.ReadKey();
        }
    }
}
