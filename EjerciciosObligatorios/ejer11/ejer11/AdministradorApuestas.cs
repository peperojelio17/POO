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
        public List<Persona> Jugadores {  get { return jugadores; } }

        private int cantJugadores;
        private int monto;
        private int cantPartidos;
        public List<Partido> partidos;
        private Dictionary<int, Persona> apuestas;
        public Dictionary<Persona, int> aciertos;
        public bool jornadaTermidada;

        public AdministradorApuestas(List<Persona> _jugadores, int _cantPartidos)
        {
            jornadaTermidada = false;
            aciertos = new Dictionary<Persona, int>();
            partidos = new List<Partido>();
            r = new Random(); 
            jugadores = new List<Persona>();

            foreach (var j in _jugadores) { 
             if(j.Dinero > 0)
                {
                    jugadores.Add(j);
                }
            }

            cantJugadores = _jugadores.Count;
            cantPartidos = _cantPartidos;
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

            List <Persona> borrar = new List<Persona>();
            foreach (Persona p in jugadores)
            {
                if (p.Dinero > 0)
                {
                    monto += 1;
                    p.Dinero -= 1;
                }
                else 
                { 
                    borrar.Add(p);
                }
            }
            if(borrar.Count > 0)
            {
                foreach(Persona b in borrar)
                {
                    jugadores.Remove(b);
                }
                borrar.Clear();
            }
        }
        public void apuesta()
        {
            int cantGanadores = 0;
            int premio = 0;
            while (!jornadaTermidada)
            {
                llenarMonto();
                foreach (Persona p in jugadores)
                {
                    for (int i = 0; i < cantPartidos; i++) p.apuesta(i);
                }
                partidos.Clear();
                llenarPartidos();
                compararResultados();
            }
            if (jornadaTermidada)
            {
                foreach (Persona p in jugadores)
                    if (aciertos[p] >=2) cantGanadores++;
                premio = monto / cantGanadores;
                foreach (Persona p in jugadores)
                    if (aciertos[p] >= 2) p.Dinero += premio;
            }
        }
        private void compararResultados()
        {
            for (int i = 0; i < cantPartidos; i++)
            {
                foreach(Persona p in jugadores)
                {
                    if(partidos[i].EquipoA == p.ApuestaPartidos[i] && p.Dinero>0)
                    {
                        aciertos[p] += 1;
                    }
                }
            }
            foreach (Persona p in jugadores)
            {
                if(aciertos[p] >= 2) jornadaTermidada = true;
            }
        }
    }
}
