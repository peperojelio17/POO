using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer11
{
    public class AdministradorApuestas
    {
        private Random r;
        private List<Persona> jugadores;
        private int cantJugadores;
        private int monto;
        private int cantPartidos;
        public List<Partido> partidos;
        private Dictionary<int, Persona> apuestas;
        public Dictionary<Persona, int> aciertos;

        public AdministradorApuestas(List<Persona> _jugadores, int _cantPartidos) 
        {
            aciertos = new Dictionary<Persona, int>();
            partidos = new List<Partido>();
            r = new Random();
            jugadores = _jugadores;
            cantJugadores = _jugadores.Count;
            cantPartidos = _cantPartidos;
            llenarMonto();
            llenarPartidos();
            llenarAciertos();
        }
        private void llenarPartidos() 
        {
            for (int i = 0; i < cantPartidos; i++) 
            { 
                partidos.Add(new Partido());
            }
        }
        private void llenarAciertos()
        {
            foreach (Persona p in jugadores)
            {
                aciertos.Add(p, 0);
            }
        }

        private void llenarMonto()
        {
            foreach(Persona p in jugadores)
            {
                if (p.Dinero > 0) 
                {
                    monto += 1;
                    p.Dinero -= 1;
                }
            }
        }
        public void apuesta()
        {
            foreach (Persona p in jugadores)
            {
                for (int i = 0; i < cantPartidos; i++) p.apuesta(i);
            }
            compararResultados();
        }
        private void compararResultados()
        {
            for (int i = 0; i < cantPartidos; i++)
            {
                foreach(Persona p in jugadores)
                {
                    if(partidos[i].EquipoA == p.ApuestaPartidos[i])
                    {
                        aciertos[p] += 1;
                    }
                }
            }
        }
    }
}
