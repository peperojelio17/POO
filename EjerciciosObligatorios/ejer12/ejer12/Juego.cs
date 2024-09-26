using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    public class Juego
    {
        private List<Jugador> jugadores;
        private Revolver revolver;
        private int JugadorActivo;
        public Juego(List<Jugador> jugadores, Revolver revolver)
        {
            this.jugadores = jugadores;
            this.revolver = revolver;
            JugadorActivo = 0;
        }
        public bool finJuego()
        {
            bool muerte = false;
            foreach (Jugador jugador in jugadores) if (!jugador.Vivo) muerte = true;
            return muerte;
        }
        public void ronda()
        {
            jugadores[JugadorActivo].disparar(revolver);
            Console.ForegroundColor = (jugadores[JugadorActivo].Vivo) ? ConsoleColor.White : ConsoleColor.Red;
            Console.WriteLine(
                (jugadores[JugadorActivo].Vivo) ? 
                $"{jugadores[JugadorActivo].Nombre} no ha muerto en esta ronda" : 
                $"{jugadores[JugadorActivo].Nombre} se ha muerto ");
            JugadorActivo = (JugadorActivo < jugadores.Count - 1) ? JugadorActivo + 1 : 0;
        }
    }
}
