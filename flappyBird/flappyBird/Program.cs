using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace flappyBird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Ave flappy = new Ave();
            Tubo tubo1 = new Tubo(110);
            Tubo tubo2 = new Tubo(30);
            Tubo tubo3 = new Tubo(55);
            Tubo tubo4 = new Tubo(80);
            List<Tubo> tubos = new List<Tubo>() { tubo1, tubo2, tubo3, tubo4 };
            Tablero t = new Tablero();
            while (flappy.colision(tubos)) {
                t.puntos = flappy.Puntos;
                if (Console.KeyAvailable)
                {
                    var tecla = Console.ReadKey(true).Key;
                    if (tecla == ConsoleKey.Spacebar)
                        flappy.saltar();
                }
                foreach (Tubo tubo in tubos)
                {
                    tubo.mover();
                    tubo.dibujar();
                }
                flappy.caida();
                flappy.dibujar();
                t.dibujar();
                Thread.Sleep(100);
            }
                t.perdiste();
            while (true)
            {
            }
        }
    }
}
