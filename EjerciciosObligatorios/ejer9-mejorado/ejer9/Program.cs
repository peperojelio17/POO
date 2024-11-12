using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Pelicula peli = new Pelicula("Star wars", 120, 12, "Eugenia Caballero");
            Cine cine = new Cine(peli, 100);

            Espectador e1 = new Espectador("Juan", 15, 180);
            Espectador e2 = new Espectador("Gino", 21, 180);
            Espectador e3 = new Espectador("Muriel", 18, 230);
            Espectador e4 = new Espectador("Anny", 18, 117);
            Espectador e5 = new Espectador("Juanny", 15, 180);
            List<Espectador> espectadores = new List<Espectador>() { e1,e2, e3, e4, e5 };

            cine.dibujar();

            cine.sentar(espectadores);
            Console.WriteLine();
            foreach (Espectador e in espectadores)
                Console.WriteLine(e.Asiento);
            Console.ReadKey();
        }
    }
}
