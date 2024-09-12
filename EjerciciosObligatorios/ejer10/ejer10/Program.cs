using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Baraja mazo = new Baraja();
            Carta carta = new Carta();
            Console.WriteLine("Baraja:");
            Console.WriteLine(mazo.mostrarBaraja());

            Console.WriteLine();
            mazo.barajar();
            Console.WriteLine("Baraja mezclada:");

            Console.WriteLine(mazo.mostrarBaraja());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Siguiente carta y carta disponible:");

            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.cartasDisponibles());
            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.cartasDisponibles());
            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.cartasDisponibles());
            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.siguienteCarta());
            Console.WriteLine(mazo.cartasDisponibles());
            Console.WriteLine(mazo.darCartas(13));
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Cartas descartadas:");
            Console.WriteLine(mazo.cartasMonton());
            Console.WriteLine();
            Console.WriteLine("baraja final:");
            Console.WriteLine(mazo.mostrarBaraja());
            Console.ReadKey();
        }
    }
}
