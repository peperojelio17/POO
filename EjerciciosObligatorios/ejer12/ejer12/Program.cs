using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Revolver revolver = new Revolver();
            List<Jugador> jugadores = new List<Jugador>();
            for (int i = 1; i <= 6; i++) { 
                jugadores.Add(new Jugador(i));
            }
            Juego juego = new Juego(jugadores,revolver);
            while(!juego.finJuego()) juego.ronda();
            Console.ReadKey();
        }
    }
}
