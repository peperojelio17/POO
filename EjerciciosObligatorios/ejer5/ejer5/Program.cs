using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sEntregados = 0;
            int vEntregados = 0;
            int vRepetidos = 0;
            Serie TWD = new Serie("the walking dead", 11,"Zombies", "Frank Darabont");
            Serie TheO = new Serie("the office", 9,"Comedia", "Greg Daniels");
            Serie GG = new Serie("gossip girl", 6,"Drama", "Josh Schwartz");
            Serie OC = new Serie("The O.C.","Josh Schwartz");
            Serie SH = new Serie("Shadowhunters", "Ed Decter");
            Serie[] series = new Serie[] { TWD, TheO, GG, OC, SH };
            Serie mayorT = series[0];
            
            Videojuego MB = new Videojuego("Mario Bros", 2 ,"plataformas", "Nintendo");
            Videojuego PM = new Videojuego("Pacman", 100 ,"accion", "Atari");
            Videojuego TT = new Videojuego("Tetris", 100 ,"logica", "Sega");
            Videojuego KH = new Videojuego("Kingdom Hearts", 80 ,"lucha", "Square Enix");
            Videojuego Zelda = new Videojuego("The Legend of Zelda: Ocarina of Time", 50);
            Videojuego[] videojuegos = new Videojuego[] {MB, PM, TT, KH, Zelda};
            Videojuego mayorH = videojuegos[0];
            TWD.entregar();
            OC.entregar();
            SH.entregar();
            TT.entregar();
            MB.entregar();

            foreach (var item in series)
                sEntregados += (item.isEntregado()) ? 1 : 0;
            Console.WriteLine($"Hay {sEntregados} series entregadas:");
            foreach (var item in series)
            {
                if (item.isEntregado())
                    Console.WriteLine($"{item.Titulo}: Temporadas:{item.NumTemporadas} ---- Genero:{item.Genero} ---- Creador:{item.Creador} ---- Entregado:{item.isEntregado()}");
            }
            Console.WriteLine();
            foreach (var item in videojuegos)
                vEntregados += (item.isEntregado()) ? 1 : 0;
            Console.WriteLine($"Hay {vEntregados} videojuegos entregados:");
            foreach (var item in videojuegos)
            {
                if (item.isEntregado())
                    Console.WriteLine($"{item.Titulo}:  Horas estimadas:{item.HEstimadas} ---- Genero:{item.Genero} ---- Compañia:{item.Compañia} ---- Entregado:{item.isEntregado()}");
            }
            foreach (var item in series)
            {
                mayorT = (mayorT.compareTo(item.NumTemporadas) < 0) ? item : mayorT;
                vRepetidos += (mayorT.compareTo(item.NumTemporadas) == 0 && mayorT.Titulo != item.Titulo) ? 1 : 0;
            }
            Console.WriteLine();

            Console.WriteLine(vRepetidos == 0 ? "La serie con más temporadas es:" : "Las series con más temporadas son:");
            foreach (var item in series){
                if (mayorT.compareTo(item.NumTemporadas) == 0)
                    Console.WriteLine($" -{item.Titulo}: Temporadas:{item.NumTemporadas} ---- Genero:{item.Genero} ---- Creador:{item.Creador} ---- Entregado:{item.isEntregado()}");
            }
            Console.WriteLine();

            foreach (var item in videojuegos)
            {
                mayorH = (mayorH.compareTo(item.HEstimadas) < 0) ? item : mayorH;
                vRepetidos += (mayorH.compareTo(item.HEstimadas) == 0 && mayorH.Titulo != item.Titulo) ? 1 : 0;
            }
            Console.WriteLine(vRepetidos == 0 ? "El juego con la más horas estimadas es:" : "Los juegos con la más horas estimadas son:");
            foreach (var item in videojuegos)
            {
                if (mayorH.compareTo(item.HEstimadas) == 0)
                    Console.WriteLine($" -{item.Titulo}:  Horas estimadas:{item.HEstimadas} ---- Genero:{item.Genero} ---- Compañia:{item.Compañia} ---- Entregado:{item.isEntregado()}");
            }

            Console.ReadKey();
        }
    }
}
